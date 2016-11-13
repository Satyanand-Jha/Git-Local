          static string getAge(string dateOfBirthAsString)
        {
            string _age = "age_calc_error";
            DateTime _dateOfBirth;
            if (!string.IsNullOrWhiteSpace(dateOfBirthAsString) && 
                 DateTime.TryParse(dateOfBirthAsString, out _dateOfBirth))
            {
                int _years = 0, _months = 0, _dayDifference = 0;
                DateTime _todaysDate = DateTime.Now;
                
                if (_todaysDate > _dateOfBirth)
                {
                    _dayDifference = _todaysDate.Day - _dateOfBirth.Day;

                    _todaysDate = _dayDifference < 0 ? _todaysDate.AddMonths(-1) : _todaysDate;

                    _years = _todaysDate.Month >= _dateOfBirth.Month ?
                             _todaysDate.Year - _dateOfBirth.Year :
                             _todaysDate.Year - _dateOfBirth.Year - 1;

                    _months = _todaysDate.Month >= _dateOfBirth.Month ?
                             (_todaysDate.Month - _dateOfBirth.Month) :
                             (12 - (_dateOfBirth.Month - _todaysDate.Month));
                }
                _age = getAgeToDspaly(_years, _months);                             
            }
            return _age;
        }

        static string getAgeToDspaly(int years, int months)
        {
            string _yearsText, _monthsText;

            _yearsText = years > 1 ? "Years" : "Year";
            _monthsText = months > 1 ? "Months" : "Month"; 
            string _ageToDisplay = months > 0 ?
                                   string.Format("{0} {1} {2} {3}", years.ToString(), _yearsText , months.ToString(), _monthsText):
                                   (years > 0 ? 
                                        string.Format("{0} {1}", years.ToString(), _yearsText):
                                        string.Format("{0} {1} {2} {3}", years.ToString(), _yearsText, months.ToString(), _monthsText));            
            return _ageToDisplay;
        }

    }
}
