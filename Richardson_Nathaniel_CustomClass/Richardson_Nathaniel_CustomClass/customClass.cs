using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Richardson_Nathaniel_CustomClass
{
    class customClass
    {
        string mName;
        decimal mStartCheck;
        decimal mStartSave;


        public customClass(string _Name, decimal _StartCheck, decimal _StartSave)
        {
            mName = _Name;
            mStartCheck = _StartCheck;
            mStartSave = _StartSave; // savings
        }

        // getter method

        public string Get_mName()
        {

            return mName;
        }

        public decimal Get_MSC() 
        {
            return mStartCheck;
        }

        public decimal GetSB() // get savings
        {
            return mStartSave;
        }

        public void SetSB_W(decimal _StartBank) //Savings subtract
        {
            mStartSave = mStartSave - _StartBank;

        }

        public void SetSC_W(decimal _StartCheck) //checkings subtract
        {
           mStartCheck= mStartCheck - _StartCheck;
        }

        public void SetSB_D(decimal _StartBank)
        {
           mStartCheck= mStartCheck+_StartBank;
        }
        public void SetSC_D(decimal _StartCheck) //savings add
        {
           mStartSave = mStartSave +_StartCheck;
        }
    }
}
