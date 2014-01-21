using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

namespace LINQ_test
{
    class PersonalInfoClass
    {
        private Table<personal_info_t> _personalInfoTables;
        private dbDataContext _dataContext;

        public void AddNewPerson(string personID, string name, string login,
                                        string password, string position, string phone, string additionalPhone,
                                        DateTime birthday, string homeAddress, int salaryPerDay)
        {
            _dataContext = new dbDataContext();
            _personalInfoTables = _dataContext.GetTable<personal_info_t>();

            //var persons = personalInfoTables.Where(person => person.additional_phone == "000000").ToList();

            personal_info_t myPerson = new personal_info_t();
            myPerson.person_id = personID;
            myPerson.name = name;
            myPerson.staff_login = login;
            myPerson.staff_password = password;
            myPerson.position = position;
            myPerson.phone = phone;
            myPerson.additional_phone = additionalPhone;
            myPerson.birthday = birthday;
            myPerson.home_address = homeAddress;
            myPerson.salary_per_day = salaryPerDay;
            
            _personalInfoTables.InsertOnSubmit(myPerson);
            _dataContext.SubmitChanges();
        }

        public Table<personal_info_t> GetAllPersonalInfos()
        {
//            var res = from a in _dataContext.GetTable<personal_info_t>()
//                select a.person_id;
            return _dataContext.GetTable<personal_info_t>();
        }
        

    }
}
