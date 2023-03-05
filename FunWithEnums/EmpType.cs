using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithEnums
{
    /// <summary>
    /// Najprostszy typ (Typ wyliczeniowy enum)
    /// domyślnie do przechowywania warotści liczbowej w enum służy int
    /// </summary>
    public enum EmpType // : int
    {
        Manager,            //0
        Grunt,              //1
        Contractor,         //2
        VicePresident,      //3
        Worker = 102,       //102
        Boss                //103
    }

    /// <summary>
    /// Kształty - numeracja nie po koleji
    /// </summary>
    public enum Shape : byte  //- tu zmieniliśmy na byte czyli 4 razy mniejszy
    {
        Squer = 3,      //3
        Circle = 1,     //1
        Rectangle = 7   //7
    }
}