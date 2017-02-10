namespace kRPCUtilities
{
    public class KerbalTimeSpan
    {
        #region Properties

        public double Years { get; set; }
        public double Days { get; set; }
        public double Hours { get; set; }
        public double Minutes { get; set; }
        public double Seconds { get; set; }
        public double TotalYears { get; set; }
        public double TotalDays { get; set; }
        public double TotalHours { get; set; }
        public double TotalMinutes { get; set; }
        public double TotalSeconds { get; set; }

        #endregion

        public void FromSeconds(double value)
        {
            TotalSeconds = value;
            TotalMinutes = TotalSeconds / 60;
            TotalHours = TotalMinutes / 60;
            TotalDays = TotalHours / 6;
            TotalYears = TotalDays / 426.08;
        }

        public void FromMinutes(double value)
        {
            TotalMinutes = value;
            TotalSeconds = TotalMinutes * 60;
            TotalHours = TotalMinutes / 60;
            TotalDays = TotalHours / 6;
            TotalYears = TotalDays / 426.08;
        }

        public void FromHours(double value)
        {
            TotalHours = value;
            TotalDays = TotalHours / 6;
            TotalYears = TotalDays / 426.08;
            TotalMinutes = TotalHours * 60;
            TotalSeconds = TotalMinutes * 60;
        }

        public void FromDays(double value)
        {
            TotalDays = value;
            TotalYears = TotalDays / 426.08;
            TotalHours = TotalDays * 6;
            TotalMinutes = TotalHours * 60;
            TotalSeconds = TotalMinutes * 60;
        }

        public void FromYears(double value)
        {
            TotalYears = value;
            TotalDays = TotalYears * 426.08;
            TotalHours = TotalDays * 6;
            TotalMinutes = TotalHours * 60;
            TotalSeconds = TotalMinutes * 60;
        }
    }
}