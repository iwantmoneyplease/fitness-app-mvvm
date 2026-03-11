using System.Text.Json.Serialization;

namespace fitness_app_mvvm.Model
{
    [JsonPolymorphic(TypeDiscriminatorPropertyName = "$type")]
    [JsonDerivedType(typeof(UserGoal), "user")]
    [JsonDerivedType(typeof(UserHistory), "userhistory")]
    [JsonDerivedType(typeof(UserSettings), "usersettings")]
    public abstract class User
    {
        // Medlemsvariabler
        public enum Type { UserGoal, UserHistory, UserSettings };
        private Type userSection;
        #region outdatedfunc
        //private string registrationNumber = string.Empty;
        //private string manufacturer = string.Empty;
        //private string modelName = string.Empty;
        //private int modelYear = 0;
        #endregion

        public abstract string GetDesc();

        // Konstruktor (en metod med samma namn som klassen, som returnerar ett objekt)
        protected User() { }
        public User(Type userSection) // en konstruktor kan, men måste inte, ta parametrar
        {
            this.userSection = userSection;
        }

        public Type UserType
        {
            get { return userSection; }
            set { userSection = value; }
        }

        #region outdatedCode
        //// Get-Set för att hålla variablerna privata, och för att validera inkommande värden från UI (user interface, användargränssnittet)
        //public string RegistrationNumber
        //{

        //}

        ////TODO Tillverkare ska valideras, sparas i objektet och visas i UI
        //public string ModelName
        //{
        //    get { return modelName; }
        //    set 
        //    {
        //        if (!value.All(c => char.IsLetterOrDigit(c) || char.IsWhiteSpace(c)))
        //        {
        //            throw new ArgumentException("Modellfältet måste ha giltigt innehåll");
        //        }
        //        else
        //        {
        //            modelName = value;
        //        }
        //    }
        //}

        //public string ModelYear
        //{
        //    get { return modelYear.ToString(); }
        //    set
        //    {
        //        if (int.TryParse(value, out int year))
        //        {
        //            if (year >= 1895 && year <= DateTime.Now.Year)
        //            {
        //                modelYear = year;
        //            }
        //            else
        //            {
        //                throw new ArgumentException("Året måste vara riktigt");
        //            }
        //        }
        //        else
        //        {
        //            throw new ArgumentException("Årfältet kan enbart ha siffror");
        //        }
        //    }
        //}

        ////TODO Modell ska valideras, sparas i objektet och visas i UI
        //public string Manufacturer
        //{
        //    get { return manufacturer; }
        //    set
        //    {
        //        if (!value.All(c => char.IsLetterOrDigit(c) || char.IsWhiteSpace(c)))
        //        {
        //            throw new ArgumentException("Tillverkarfältet måste ha giltigt innehåll");
        //        }
        //        else
        //        {
        //            manufacturer = value;
        //        }

        //    }
        //}
        #endregion
    }
}