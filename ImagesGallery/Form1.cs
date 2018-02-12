using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// pliki ikon przycisków znajdują się w zasobach "Resources" widoczne w widoku projektu
// cały kod jest w zawarty w klasnie okna "Form1"

namespace ImagesGallery
{
    public partial class Form1 : Form
    {
        // tablica obsługiwanych formatów plików
        private string[] supportedFileExtensions = { "*.jpg", "*.gif", "*.png", "*.bmp" };
        // tablica rozmiarów obrazków
        private int[] pictureSizes = { 64, 128, 256, 512 };  

        // pobranie aktualnej wartości z trackBara dla rozmiaru obrazka galerii
        private int PictureSize
        {
            get
            {
                return pictureSizes[trackBarPictureSize.Value];
            }
        }
        // właściwość tylko do oczytu, czy jesteśmy w trybie galerii?
        // można się odwołać bezpośrednio do checkBoxGallery.Checked, ale tak jest ładniej i można realizować
        // dodatkową logike
        private bool GalleryMode
        {
            get
            {
                return checkBoxGallery.Checked;
            }
        }

        private string lastLoadedPath;  // do usunięcia
        // domyslny tryb wyświetlania obrazka
        private PictureBoxSizeMode pictureSizeMode = PictureBoxSizeMode.Normal;
        // Słownik przecohwujący nazwę obrazka do nazwy pliku
        private Dictionary<string, string> pictureToFileDictionary = new Dictionary<string, string>();

        // ukrywanie paneli, kiedy jesteśmy w trybie podglądu jednego obrazka, panele należy schować
        private void HidePanelsInGalleryMode()
        {
            if (GalleryMode)
            {
                panelRight.Visible = false;
                panelBottom.Visible = false;
                groupBoxGallery.Enabled = true;

                ClearMetaLabels();
            }
            else
            {
                panelRight.Visible = true;
                panelBottom.Visible = true;
                groupBoxGallery.Enabled = false;
            }
            flowLayoutPanel1.Invalidate();
        }

        // kontruktor okna
        public Form1()
        {
            InitializeComponent();
            //HidePanelsInGalleryMode();  // ustaw widoczność paneli galerii na początku programu
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            HidePanelsInGalleryMode();  // ustaw widoczność paneli galerii na początku programu
        }

        // dodaj liste plików do komponentu listy
        private void AddFilesToListBox(string[] files)
        {
            listBoxFiles.Items.Clear(); // najpierw wyczyść
            foreach (var file in files) // i dodaj wszystkie przekazane w argumencie
            {
                listBoxFiles.Items.Add(file); 
            }
        }

        // wyczyść informacje w etykietach z panelu pocznego "META"
        private void ClearMetaLabels()
        {
            labelMetaName.Text = "Nazwa: ";
            labelMetaWidth.Text = "Szerokość: ";
            labelMetaHeight.Text = "Wysokość: ";
            labelMetaPixelFormat.Text = "Format: ";
        }

        // Dodaj jeden obrazek do panellu głównego
        // za przechowywanie wyświetlanych obrazków odpowiedzialna jest kontrolka "flowLayoutPanel1"
        private void AddSinglePictureToPanel(string file)
        {
            // wyczyść kontrolki i 
            flowLayoutPanel1.Controls.Clear();
            pictureToFileDictionary.Clear();

            // nowy obiekt kontrolki typu PictureBox
            PictureBox pictureBox = new PictureBox();
            pictureBox.Name = "Picture";    // domyślna nazwa
            // załaduj obraz ze wskazanego pliku, mało optymalne robić do za każdym razem, ale tu wystarcza
            pictureBox.Image = Image.FromFile(file);    
            // odczytaj interesujące nas właściwości obrazka, var - zamiast specyfikować konkretny typ np. "int", niech zrobi to kompilator
            // piszę się szybciej i wygodniej, czasmi nie interesuja nas te szczegół, chcemy tylko użyć tych informacji
            var width = pictureBox.Image.Size.Width;
            var height = pictureBox.Image.Size.Height;
            var pixelFormat = pictureBox.Image.PixelFormat;

            // uwstaw tekst etykiet meta, tylko przy ładowaniu pojedyńczego obrazka
            labelMetaName.Text = "Nazwa: " + Path.GetFileName(file);    // Klasa Path udostępnia kilka przydatnych funkcji, jak pobranie nazwy pliku lub rozszerzenia
            labelMetaWidth.Text = "Szerokość: " + width.ToString(); // podczas przypisania zamień na tekst, przy "int" nie jest konieczne
            labelMetaHeight.Text = "Wysokość: " + height.ToString();
            labelMetaPixelFormat.Text = "Format: " + pixelFormat.ToString(); // ale tutaj już tak

            // ustaw rozmiar komponentu na ten załadowanego obrazka
            //pictureBox.Size = new Size(pictureBox.Image.Width, pictureBox.Image.Height);
            pictureBox.Size = flowLayoutPanel1.Size;    // tak wygląda lepiej, obrazek będzie na środku na czarnym tle

            pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;   // tryb wyświetlania
            pictureBox.BorderStyle = BorderStyle.FixedSingle; // tryb ramki, 'płaska'
            pictureBox.DoubleClick += Picture_DoubleClick; // dodaj obsługę zdarzenia dwukliku

            pictureToFileDictionary.Add(pictureBox.Name, file); // dodaj do słownika
            flowLayoutPanel1.Controls.Add(pictureBox); // dodaj kontrolke, inaczej "umieść ją w oknie"
            flowLayoutPanel1.Invalidate();  // odśwież (odrysuj) kontrolke
        }

        // dodanie wielu obrazków, w argumencie tablica
        private void AddGalleryPicturesToPanel(string[] files)
        {
            flowLayoutPanel1.Controls.Clear();
            pictureToFileDictionary.Clear();

            int counter = 0;    // licznik porządkowy
            foreach(string file in files)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Name = "Picture_" + (counter++); // nadaj każdemu kolejne nazwy Picture_0, Picture_1 itd...
                pictureBox.Image = Image.FromFile(file);
                pictureBox.Size = new Size(PictureSize, PictureSize);
                pictureBox.SizeMode = pictureSizeMode;
                pictureBox.BorderStyle = BorderStyle.FixedSingle;
                // obsługa kilku zdarzeń
                pictureBox.Click += PictureBox_Click;
                pictureBox.DoubleClick += Picture_DoubleClick;
                pictureBox.MouseHover += Picture_MouseHover;
                pictureBox.MouseLeave += Picture_MouseLeave; ;

                pictureToFileDictionary.Add(pictureBox.Name, file);
                flowLayoutPanel1.Controls.Add(pictureBox);
            }
        }

        // wsyzstkie zdarzenia mają te same argumenty (object sender, EventArgs e),

        private void PictureBox_Click(object sender, EventArgs e)
        {
            // można usunąć
            //flowLayoutPanel1.Controls.Clear();
            //var picture = sender as Control;
            //AddSinglePictureToPanel(pictureToFileMap[picture.Name]);
        }

        // Obsługa zdarzeń dla opuszczenia obszaru obrazka przez kursor
        private void Picture_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender; // konwersja ogólnego obiektu na specyficzny typ PictureBox
            pb.BorderStyle = BorderStyle.FixedSingle; // teraz mozemy się odwołac do jego właściwości
        }
        // obsługa zdarzenia najechania kursorem na obrazek
        private void Picture_MouseHover(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BorderStyle = BorderStyle.Fixed3D;
        }

        private void Picture_DoubleClick(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            // uruchomienie procesu, system użyje domyślnej aplikacji dla otwarcia podanego pliku
            System.Diagnostics.Process.Start(pictureToFileDictionary[pb.Name]); 
        }

        // Kompletna funkcja załadowania obrazków
        private void LoadPictures(string[] files)
        {
            // najpierw wyczyść
            ClearPictures();

            // jeżeli przekazana tablica jest pusta, wyjdź
            if (files.Length == 0)
                return;

            // dodanie plików do listy
            AddFilesToListBox(files);

            // stwórz galerie lub pokaż pojedynczy obrazek
            if (GalleryMode)
            {
                AddGalleryPicturesToPanel(files);
            }
            else
            {
                // załaduj domyślne pierwszy obrazek z listy plików
                AddSinglePictureToPanel(files[0]);
                listBoxFiles.SelectedIndex = 0; // podświetl zaznaczenie na liście
            }
        }

        // przycisk "przeglądaj"
        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog()) // otwórz okno dialogowe wyboru folderów
            {
                DialogResult result = fbd.ShowDialog(); // zapisz rezultat, program jest wstrzymany do póki nie zamkniemy okna dialogowego

                // jeżeli jest ok i wybrana ścieżka folderu nie jest pusta
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    List<string> files = GetListOfFiles(fbd.SelectedPath); 

                    LoadPictures(files.ToArray());
                    HidePanelsInGalleryMode();  // jak mają zachować się panele?

                    textBoxDirectoryPath.Text = fbd.SelectedPath; // ustaw ścieżke w textBoxie
                    lastLoadedPath = fbd.SelectedPath;  // ostatnio załadowana ścieżka, miało się przydać....
                }
            }
        }

        // pobiera listę plików z podanej ścieżki
        private List<string> GetListOfFiles(string directory)
        {
            // jeżeli katalog nie istnieje zwróci pustą liste
            if (Directory.Exists(directory) == false)
                return new List<string>();

            // można ładować tylko pojdyńcze rozszerzenie za pomocą Directory.GetFiles, dlatego dla każdego z osobna trzeba tworzyć liste
            // dzięki temu że rozszerzenia mamy zapisane w tablicy, możemy w wygodny sposób je ładować, dodając nowe, nie zmieniając tego kodu
            List<string> allFiles = new List<string>();
            foreach (string fileExtension in supportedFileExtensions)
            {
                var filess = Directory.GetFiles(directory, fileExtension, SearchOption.TopDirectoryOnly);
                allFiles.AddRange(filess);
            }
            // na koniec zwróc liste zawierająca wszystkie załadowane plii danych typów
            return allFiles;
        }

        // przycisk wyłączony, do celów testowych
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            List<string> files = GetListOfFiles(textBoxDirectoryPath.Text);
            LoadPictures(files.ToArray());
            HidePanelsInGalleryMode();
        }

        // zdarzenie zmiany rozmiaru obrazka w kontrolce trackBar
        private void trackBarPictureSize_Scroll(object sender, EventArgs e)
        {
            // dla każdego obrazka (kontrolki) w flowLayoutPanel1
            foreach (var control in flowLayoutPanel1.Controls)
            {
                PictureBox pb = (PictureBox)control;
                pb.Size = new Size(PictureSize, PictureSize); // uwstaw odpowiendi rozmiar
            }
        }

        // uaktualnij tryb wyświetlania obrazków w galerii
        private void UpdatePicturesSizeMode(PictureBoxSizeMode mode)
        {
            pictureSizeMode = mode;
            foreach (var control in flowLayoutPanel1.Controls)
            {
                PictureBox pb = (PictureBox)control;
                pb.SizeMode = pictureSizeMode;
            }

            if(pictureSizeMode == PictureBoxSizeMode.AutoSize)  // jeżeli jest 'autoSize' nie można kontrolować rozmiaru obrazka ręcznie
            {
                trackBarPictureSize.Enabled = false;
            }
            else
            {
                trackBarPictureSize.Enabled = true;
            }
        }

        // WYŁĄCZONY wszystko: liste, obrazki z okna, pomocniczy słownik
        private void ClearPictures()
        {
            listBoxFiles.Items.Clear();
            flowLayoutPanel1.Controls.Clear();
            pictureToFileDictionary.Clear();
        }

        // WYŁĄCZONY pomocniczy przycisk testowy do czyszczenia
        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearPictures();
        }

        // obsługa kolejnych przycisków wyboru tryby wyświetlania obrazka
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePicturesSizeMode(PictureBoxSizeMode.CenterImage);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePicturesSizeMode(PictureBoxSizeMode.Normal);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePicturesSizeMode(PictureBoxSizeMode.StretchImage);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePicturesSizeMode(PictureBoxSizeMode.AutoSize);
        }

        // zdarzenie zmiany wybranego indeksu na liście
        private void listBoxFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(GalleryMode == false)
            {
                // jeżeli NIE jesteśmy w trybie galerii, po każdym wyborze załaduj obrazek i pokaż
                string selectedFile = listBoxFiles.SelectedItem.ToString();
                AddSinglePictureToPanel(selectedFile);
            }
        }

        // ustaw tryb galerii, przy okazji ośwież i załaduj wsyzstkie obrazki ze ścieżki z "textBoxDirectoryPath"
        private void checkBoxGallery_CheckedChanged(object sender, EventArgs e)
        {
            List<string> files = GetListOfFiles(textBoxDirectoryPath.Text);
            LoadPictures(files.ToArray());
            HidePanelsInGalleryMode();
        }


        private void buttonRotateLeft_Click(object sender, EventArgs e)
        {
            if (flowLayoutPanel1.Controls.Count == 0)
                return;
            PictureBox pb = flowLayoutPanel1.Controls[0] as PictureBox;
            pb.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);  // uwstaw tryb rotacji, obrót w lewo
            pb.Invalidate();
        }

        private void buttonRotateRight_Click(object sender, EventArgs e)
        {
            if (flowLayoutPanel1.Controls.Count == 0)
                return;
            PictureBox pb = flowLayoutPanel1.Controls[0] as PictureBox;
            pb.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);   // obrót w prawo
            pb.Invalidate();
        }

        // zdarzenie zmiany rozmiaru kontrolki flowLayoutPanel1
        private void flowLayoutPanel1_Resize(object sender, EventArgs e)
        {
            if(!GalleryMode)
            {
                if(flowLayoutPanel1.Controls.Count > 0)
                {
                    PictureBox pb = flowLayoutPanel1.Controls[0] as PictureBox;
                    pb.Size = flowLayoutPanel1.Size;
                }
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            // brak selekcji, -1 to wartość domyślna, nie obsługujemy
            if (listBoxFiles.SelectedIndex == -1)
                return;

            if (listBoxFiles.SelectedIndex < listBoxFiles.Items.Count - 1)
            {
                listBoxFiles.SelectedIndex++; // wuybierz następny obrazek jeżeli można
                AddSinglePictureToPanel(listBoxFiles.SelectedItem.ToString());  // element listy do ścieżka do pliku
            }
        }

        // poprzedni
        private void buttonPrev_Click(object sender, EventArgs e)
        {
            if (listBoxFiles.SelectedIndex > 0)
            {
                listBoxFiles.SelectedIndex--;   // zmniejsz jeżeli większe od 0
                AddSinglePictureToPanel(listBoxFiles.SelectedItem.ToString());
            }
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            // ponieważ zawsze można kliknać, wyjdź jeżeli nie ma załadowanych obrazków
            if (listBoxFiles.Items.Count == 0)
                return;

            listBoxFiles.SelectedIndex = 0; // ustaw pierwszy
            AddSinglePictureToPanel(listBoxFiles.SelectedItem.ToString());
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            if (listBoxFiles.Items.Count == 0)
                return;

            listBoxFiles.SelectedIndex = listBoxFiles.Items.Count - 1; // uwstaw ostatni
            AddSinglePictureToPanel(listBoxFiles.SelectedItem.ToString());
        }
    }
}
