using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    public class Playlist
    {
        private List<string> songs;
        private int currentSongIndex;
        public Playlist()
        {
            songs = new List<string>();
            currentSongIndex = 0;
        }
        public void AddSong(string song) //Добавляет аудиозапись
        {
            songs.Add(song);
        }
        public void AddSong(string song, int index) //Добавляет аудиозапись
        {
            if (index >= 0 && index <= songs.Count)
            {
                songs.Insert(index, song);
                if (index <= currentSongIndex)
                    currentSongIndex++;
            }
            else
            {
                MessageBox.Show("Неверный индекс!");
            }
        }
        public void NextSong() //Переход к след. аудиозаписи
        {
            if (currentSongIndex < songs.Count - 1)
                currentSongIndex++;
            else
                MessageBox.Show("Достигнут конец плейлиста!");
        }
        public int GetCount()  //Возврощает количество аудиoзописей в листбоксе
        {
            return songs.Count;
        }
        public void GoToFirstSong() //Переход к первой аудиозаписи
        { 
            currentSongIndex=0; 
        }
        public int GetCurrentIndex() //Возврощает индекс аудиозаписи
        { 
            return currentSongIndex; 
        }
        public void PreviousSong() //Переход к пред. аудиозаписи 
        {
            if (currentSongIndex > 0)
                currentSongIndex--;
            else
                MessageBox.Show("Достигнуто начало плейлиста!");
        }
        public void GoToSong(int index) //Переход к аудиозаписи по индексу "номер"
        {
            if (index >= 0 && index < songs.Count)
                currentSongIndex = index;
            else
                MessageBox.Show("Неверный индекс!");
        }
        public void RemoveSong(int index) //Удаляет аудиозапись по индексу "номеру"
        {
            if (index >= 0 && index < songs.Count)
            {
                songs.RemoveAt(index);
                if (index <= currentSongIndex)
                    currentSongIndex--;
            }
            else
            {
                MessageBox.Show("Неверный индекс!");
            }
        }
        public void GoToLastSong() //Переход к пред. аудиозаписи 
        {
            currentSongIndex = songs.Count - 1;
        }
        public void RemoveSong(string song) //Удаляет аудиозапись по названию
        {
            int index = songs.IndexOf(song);
            if (index >= 0)
            {
                RemoveSong(index);
            }
            else
            {
                MessageBox.Show("Песня не найдена!");
            }
        }   
        public void ClearPlaylist() //Очиска листбокса
        {
            songs.Clear();
            currentSongIndex = -1;
        }
    }
}
