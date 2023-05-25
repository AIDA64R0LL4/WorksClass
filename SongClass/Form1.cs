using System;
using System.Windows.Forms;

namespace Zadanie3
{
    //Рыжков ПР-24 22:43 25.05.2023
//    ╭━╮----┈╭━╮
//┃╭╯┈┃┊┗━━━━━┛┊┃
//┃╰┳┳┫┏━▅╮┊╭━▅┓┃
//┃┫┫┫┫┃┊▉┃┊┃┊▉┃┃
//┃┫┫┫╋╰━━┛▅┗━━╯╋
//┃┫┫┫╋┊┊┊┣┻┫┊┊┊╋
//┃┊┊┊╰┈┈┈┈┈┈┈┳━╯
//┃┣┳┳━━┫┣━━┳╭╯
    public partial class Form1 : Form
    {
        private Playlist myPlaylist;

        public Form1()
        {
            InitializeComponent();
            myPlaylist = new Playlist();
        }
        private void button1_Click(object sender, EventArgs e) //Добавление аудиозаписи
        {
            string song = songTextBox.Text;
            if (!string.IsNullOrEmpty(song))
            {
                myPlaylist.AddSong(song);
                ListBox.Items.Add(song); 
                songTextBox.Text = string.Empty; 
            }
            else
            {
                MessageBox.Show("Введите название аудиозаписи","Ошибка");
            }
        }
        private void button2_Click(object sender, EventArgs e) //Удаление аудиозаписи
        {
            int selectedIndex = ListBox.SelectedIndex;
            if (selectedIndex >= 0)
            {
                myPlaylist.RemoveSong(selectedIndex);
                ListBox.Items.RemoveAt(selectedIndex);
            }
            else
            {
                MessageBox.Show("Выберите аудиозапись для удаления","Ошибка");
            }
        }
        private void button4_Click(object sender, EventArgs e) //Переход к след. аудиозаписи
        {
            int currentIndex = myPlaylist.GetCurrentIndex();
            int nextIndex = currentIndex + 1;

            if (nextIndex < myPlaylist.GetCount())
            {
                myPlaylist.GoToSong(nextIndex); 
                ListBox.SelectedIndex = nextIndex; 
            }
            else
            {
                myPlaylist.GoToFirstSong();
                ListBox.SelectedIndex = 0;
            }     
        }
        private void button5_Click(object sender, EventArgs e) //Переход к пред. аудиозаписи
        {
            int currentIndex = myPlaylist.GetCurrentIndex();
            int previousIndex = currentIndex - 1;

            if (previousIndex >= 0)
            {
                myPlaylist.GoToSong(previousIndex);             
               ListBox.SelectedIndex = previousIndex; 
            }
            else
            {
                myPlaylist.GoToLastSong();
                ListBox.SelectedIndex = myPlaylist.GetCount() - 1; 
            }
        }
        private void button3_Click(object sender, EventArgs e) //Очистка плейлиста
        {
            myPlaylist = new Playlist();
            ListBox.Items.Clear();
        }
        private void button6_Click(object sender, EventArgs e) //Выход  из приложения
        {
            Application.Exit();
        }
    }
}
