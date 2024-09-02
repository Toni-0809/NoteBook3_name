using NoteBook3_name.NoteBook3.Core.Data;
using NoteBook3_name.NoteBook3.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBook3_name.NoteBook3.Core.Service
{
    /// <summary>
    /// Класс, осуществляющий работу с фильмами 
    /// </summary>
    public class NoteService2
    {
        private NoteDataSource3 _dataSource;
        private List<Note> _notes = new List<Note>();
        public NoteService2(NoteDataSource3 dataSource)
        {
            _dataSource = dataSource;
            _notes = _dataSource.Get();
        }
        /// <summary>
        /// Получить все фильмы
        /// </summary>
        /// <returns></returns>
        public List<Note> GetAll()
        {
            return _notes;
        }
        /// <summary>
        /// Получить фильм по идентификатору
        /// </summary>
        /// <param name="id">Идентификатор фильма</param>
        /// <returns>null в случае, если фильм не найден</returns>
        public Note Get(int id)
        {
            foreach (Note note in _notes)
                if (note.ItemId == id)
                    return note;
            return null;
        }
        /// <summary>
        /// Добавить новый фильм
        /// </summary>
        /// <param name="note"></param>
        public void Create(Note note)
        {
            _notes.Add(note);
            _dataSource.Write(_notes);
        }
        /// <summary>
        /// Удалить фильм по идентификатору
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            foreach (Note note in _notes)
                if (note.ItemId == id)
                {
                    _notes.Remove(note);
                    break;
                }
            _dataSource.Write(_notes);
        }
        /// <summary>
        /// Обновить фильм
        /// </summary>
        /// <param name="note"></param>
        public void Update(Note note)
        {
            for (int i = 0; i < _notes.Count; i++)
                if (note.ItemId == _notes[i].ItemId)
                    _notes[i] = note;
            _dataSource.Write(_notes);
        }

    }
}