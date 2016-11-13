        static string getAge(string dateOfBirthAsString)
        {
            string _age = "_error";
            if (!string.IsNullOrWhiteSpace(dateOfBirthAsString))
            {
                int _years = 0, _months = 0;
                DateTime _todaysDate = DateTime.Now;
                DateTime _dateOfBirth = Convert.ToDateTime(dateOfBirthAsString);

                if (_todaysDate > _dateOfBirth)
                {
                    if (_todaysDate.Month >= _dateOfBirth.Month)
                    {
                        _years = _todaysDate.Year - _dateOfBirth.Year;
                        _months = _todaysDate.Month - _dateOfBirth.Month;
                    }
                    else if (_todaysDate.Month < _dateOfBirth.Month)
                    {
                        _years = (_todaysDate.Year - _dateOfBirth.Year) - 1;
                        _months = 12 - (_dateOfBirth.Month - _todaysDate.Month);
                    }   
                    _age = getAgeToDspaly(_years, _months);
                }                               
            }           
            return _age;
        }

        static string getAgeToDspaly(int years, int months)
        {
            string _ageToDisplay = "";
            if (years > 0)
            {
                _ageToDisplay = months > 0 ?
                                years.ToString() + " Years " + months.ToString() + " Months" :
                            years.ToString() + " Years";
                                
            }
            else
            {
                _ageToDisplay = months > 0 ?
                                "0 Years " + months.ToString() + " Months" :
                                "Not Available";
            }
            return _ageToDisplay;
        }