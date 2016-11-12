        static string getAge(string dateOfBirthAsString)
        {
            string _age = "";
            if (!string.IsNullOrWhiteSpace(dateOfBirthAsString))
            {
                int? _years = 0;
                int? _months = 0;
                DateTime _todaysDate = DateTime.Now;
                DateTime _dateOfBirth = Convert.ToDateTime(dateOfBirthAsString);
                if (_todaysDate > _dateOfBirth)
                {
                    if (_todaysDate.Month >= _dateOfBirth.Month)
                    {
                        _years = _todaysDate.Year - _dateOfBirth.Year;
                        _months = _todaysDate.Month - _dateOfBirth.Month;
                    }
                    else
                    {
                        _years = (_todaysDate.Year - _dateOfBirth.Year) - 1;
                        _months = _dateOfBirth.Month - _todaysDate.Month;
                    }
                    if (_years > 0)
                    {
                        _age = _months == 0 ?
                               _years.ToString() + " Years" :
                               _years.ToString() + " Years " + _months + " Months";
                    }
                    else
                    {
                        _age = _months > 0 ?
                               "0 Years " + _months.ToString() + " Months" :
                               "Not Available";
                    }
                }               
            }
            return _age;
        }
