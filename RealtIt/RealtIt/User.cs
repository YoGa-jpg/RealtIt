using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace RealtIt
{
    public class User : INotifyPropertyChanged
    {
        [Key]
        public int OwnerId { get; set; }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Patronymic { get; private  set; }
        public string Login { get; private set; }
        public string Password { get; private set; }
        public User(string Name, string Surname, string Patronymic, string Login, string Password)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Patronymic = Patronymic;
            this.Login = Login;
            this.Password = Password;
        }
        public User() { }
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void UpdateData()
        {
            OnPropertyChanged("Name");
        }
    }
}
