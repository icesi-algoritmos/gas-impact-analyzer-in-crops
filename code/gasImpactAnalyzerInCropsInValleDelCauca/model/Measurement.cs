﻿namespace model
{
    public class Measurement
    {
        private string date;
        private string authority;
        private string stationName;
        private string technology;
        private double latitude;
        private double longitude;
        private string departmentCode;
        private string department;
        private string municipalityCode;
        private string municipality;
        private string stationType;
        private double exhibitionTime;
        private string variable;
        private string unit;
        private double concentration;

        public Measurement(string date, string authority, string stationName, string technology, double latitude, double longitude, string departmentCode, string department, string municipalityCode, string municipality, string stationType, double exhibitionTime, string variable, string unit, double concentration)
        {
            this.Date = date;
            this.Authority = authority;
            this.StationName = stationName;
            this.Technology = technology;
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.DepartmentCode = departmentCode;
            this.Department = department;
            this.MunicipalityCode = municipalityCode;
            this.Municipality = municipality;
            this.StationType = stationType;
            this.ExhibitionTime = exhibitionTime;
            this.Variable = variable;
            this.Unit = unit;
            this.Concentration = concentration;
        }

        public string Date { get => date; set => date = value; }
        public string Authority { get => authority; set => authority = value; }
        public string StationName { get => stationName; set => stationName = value; }
        public string Technology { get => technology; set => technology = value; }
        public double Latitude { get => latitude; set => latitude = value; }
        public double Longitude { get => longitude; set => longitude = value; }
        public string DepartmentCode { get => departmentCode; set => departmentCode = value; }
        public string Department { get => department; set => department = value; }
        public string MunicipalityCode { get => municipalityCode; set => municipalityCode = value; }
        public string Municipality { get => municipality; set => municipality = value; }
        public string StationType { get => stationType; set => stationType = value; }
        public double ExhibitionTime { get => exhibitionTime; set => exhibitionTime = value; }
        public string Variable { get => variable; set => variable = value; }
        public string Unit { get => unit; set => unit = value; }
        public double Concentration { get => concentration; set => concentration = value; }
    }
}