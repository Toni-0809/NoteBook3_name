using NoteBook3_name.NoteBook3.App.Core;
using NoteBook3_name.NoteBook3.Core.Entity;
using NoteBook3_name.NoteBook3.Core.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBook3_name.NoteBook3.App
{
 

    public class MainViewModel : ObservableObject
    {

        private string _input = string.Empty;
        public string Input
        {
            get => _input;
            set
            {
                _input = value;
                OnPropertyChanged("Input");
            }
        }

        private ObservableCollection<Note> _NoteList2 = new ObservableCollection<Note>();
        public ObservableCollection<Note> NoteList2 { get => _NoteList2; set { _NoteList2 = value; OnPropertyChanged("NoteList2"); } }

        private NoteService2;

        private Note _selectedNote;
        public Note SelectedNote
        {
            get => _selectedNote;
            set
            {
                __selectedNote = value;
                OnPropertyChanged("SelectedNote");
            }
        }

        public MainViewModel(NoteService2 service)
        {
            NoteService3 = service;
            NoteList2 = new ObservableCollection<Note>(NoteService3.GetAll());
        }


        private RelayCommand addCommand;
        public RelayCommand AddCommand
        {
            get
            {
                return addCommand ??
                  (addCommand = new RelayCommand(obj =>
                  {
                      NoteService3.Create(
                          new Note(Input)
                          );
                      NoteList2 = new ObservableCollection<Note>(NoteService3.GetAll());
                  }));
            }
        }

        private RelayCommand deleteCommand;
        public RelayCommand DeleteCommand
        {
            get
            {
                return deleteCommand ??
                  (deleteCommand = new RelayCommand(obj =>
                  {
                      NoteService3.Delete(
                          SelectedNote2.ItemId
                          );
                      NoteList2 = new ObservableCollection<Note>(NoteService3.GetAll());
                  }));
            }
        }

        private RelayCommand editCommand;
        public RelayCommand EditCommand
        {
            get
            {
                return editCommand ??
                  (editCommand = new RelayCommand(obj =>
                  {
                      SelectedNote3.Title = Input;
                      NoteService3.Update(
                          SelectedNote3
                          );
                      NoteList2 = new ObservableCollection<Note>(NoteService3.GetAll());
                  }));
            }
        }


    }
}
