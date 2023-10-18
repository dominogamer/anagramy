using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    internal class Anagram : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        string text1; 
        string text2;
        public string Text1
        {  get 
            { 
                return text1; 
            } 
           set
            {  
                text1 = value; 
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Text1"));
            } 
        }
       public string Text2
        {
            get
            { 
                return text2; 
            }
            set
            {
                text2 = value;
                if(PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Text2"));
            }
        }
        public Anagram()
        {
            Text1 = "Dawid";
            Text2 = "Tarasinski";
        }
        public bool sprawdźanagramy
    }
}
