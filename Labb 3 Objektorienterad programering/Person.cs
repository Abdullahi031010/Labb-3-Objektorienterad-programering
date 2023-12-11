using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_3_Objektorienterad_programering
{
    public class Person

    {
        public DateTime Birthday { get; private set; }

        public Hair hair {  get; set; } 

         public Gender gender { get; private set; }

        public string eyeColor { get; set; }


        public Person(DateTime birthday, string  EyeColor, Gender GENDER, Hair haIr )
        {
          gender = GENDER;
          eyeColor = EyeColor;
          Birthday = birthday;
          hair =haIr ;
        }

        public override string ToString()
        {
            return $"Kön: {gender} \n" +
            $"ögonfärg: {eyeColor} \n" +
            $"Hårfärg: {hair.hairColor} \n" + $"Hårlängd: {hair.hairLength} \n"+
            $"Födelsedatum: {Birthday:yyyy/MM/dd}";
        }





    }
}
