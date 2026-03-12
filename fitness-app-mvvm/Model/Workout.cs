using System.Text.Json.Serialization;

namespace fitness_app_mvvm.Model
{
    [JsonPolymorphic(TypeDiscriminatorPropertyName = "$type")]
    [JsonDerivedType(typeof(WorkoutLeg), "leg")]
    [JsonDerivedType(typeof(WorkoutCore), "core")]
    [JsonDerivedType(typeof(WorkoutArm), "arm")]
    public abstract class Workout
    {
        //hejsan. du hade en massa getsets där nere. nu är de här uppe -leo xoxo
        public enum Category { Arm, Leg, Core };
        public Category WorkoutType { get; set; }
        public string Quantity { get; set; } = string.Empty;
        public string Time { get; set; } = string.Empty;
        public string ExerciseName { get; set; } = string.Empty;

        public abstract string GetDesc();

        protected Workout() { }
        protected Workout(Category type)
        {
            this.WorkoutType = type;
        }

        #region getsets
        //public Type workoutType
        //{
        //    get { return workoutType; }
        //    set { workoutType = value; }   
        //}
        //public string Quantity
        //{
        //    get { return Quantity; }
        //    set { Quantity = value; }
        //}
        //public string Time
        //{
        //    get { return Time; }
        //    set { Tíme = value; }
        //}
        //public string Sort
        //{
        //    get { return Sort; }
        //    set { Sort = value; }
        //}
        #endregion
        #region RegistrationNumber
        /*
        // Get-Set för att hålla variablerna privata, och för att validera inkommande värden från UI (user interface, användargränssnittet)
        public string RegistrationNumber
        {
            get { return registrationNumber; }

            set
            {
                if (value.Length == 6)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        if (!char.IsLetter(value[i]))
                            throw new ArgumentException("Inkorrekt registreringsnummer: De första tre tecknen måste vara bokstäver.");
                    }

                    for (int i = 3; i < 6; i++)
                    {
                        if (i < 5)
                        {
                            if (!char.IsDigit(value[i]))
                                throw new ArgumentException("Inkorrekt registreringsnummer: Det fjärde och femte tecknet måste vara siffror.");
                        }
                        else
                        {
                            if (!char.IsDigit(value[i]) && !char.IsLetter(value[i]))
                                throw new ArgumentException("Inkorrekt registreringsnummer: Det sjätte tecknet måste vara en siffra eller en bokstav.");
                        }
                    }
                }
                else
                {
                    throw new ArgumentException("Ett registreringsnummer måste bestå av exakt 6 tecken, med tre bokstäver följt av två siffror och en siffra eller bokstav.");
                }

                registrationNumber = value.ToUpper();
            }
        }
        */
        #endregion
        #region VehicleType
        /*
        // Fordonstyp tas in från dropdown-menyn, och behöver därför inte valideras
        public Type VehicleType
        {
            get { return vehicleType; }
            set { vehicleType = value; }
        }
        */
        #endregion
        #region ModelName
        /*
        //TODO Tillverkare ska valideras, sparas i objektet och visas i UI
        public string ModelName
        {
            get { return modelName; }
            set 
            {
                if (!value.All(c => char.IsLetterOrDigit(c) || char.IsWhiteSpace(c)))
                {
                    throw new ArgumentException("Modellfältet måste ha giltigt innehåll");
                }
                else
                {
                    modelName = value;
                }
            }
        }
        */
        #endregion
        #region ModelYear
        /*
        public string ModelYear
        {
            get { return modelYear.ToString(); }
            set
            {
                if (int.TryParse(value, out int year))
                {
                    if (year >= 1895 && year <= DateTime.Now.Year)
                    {
                        modelYear = year;
                    }
                    else
                    {
                        throw new ArgumentException("Året måste vara riktigt");
                    }
                }
                else
                {
                    throw new ArgumentException("Årfältet kan enbart ha siffror");
                }
            }
        }
        */
        #endregion
        #region Manufacturer 
        /*
        //TODO Modell ska valideras, sparas i objektet och visas i UI
        public string Manufacturer
        {
            get { return manufacturer; }
            set
            {
                manufacturer = value;
            }
        }
        */
        #endregion
    }
}
