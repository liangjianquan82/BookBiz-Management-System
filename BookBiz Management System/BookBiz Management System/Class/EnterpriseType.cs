// File:    EnterpriseType.cs
// Author:  Liang Jianquan
// ID:      2201546
// Course:  420-942-VA APPLICATION DEVELOPMENT 1 (DESKTOP)
// Purpose: Definition of Class EnterpriseType

using System;
using System.Data;

namespace BookBiz_Management_System
{
    public class EnterpriseType
    {
        private int enterpriseTypeId;
        private string enterpriseTypename;

        public DataSet ListEnterpriseType()
        {
            string sql = "SELECT *  FROM  Enterprise_type  " ;
            DataSet ds = new DataSet();
            ds = new Sqlconnect().select(sql);
            return ds;
        }

        public System.Collections.Generic.List<Enterprises> enterprises;

        /// <summary>
        /// Property for collection of Enterprises
        /// </summary>
        /// <pdGenerated>Default opposite class collection property</pdGenerated>
        public System.Collections.Generic.List<Enterprises> Enterprises
        {
            get
            {
                if (enterprises == null)
                    enterprises = new System.Collections.Generic.List<Enterprises>();
                return enterprises;
            }
            set
            {
                RemoveAllEnterprises();
                if (value != null)
                {
                    foreach (Enterprises oEnterprises in value)
                        AddEnterprises(oEnterprises);
                }
            }
        }

        public int EnterpriseTypeId { get => enterpriseTypeId; set => enterpriseTypeId = value; }
        public string EnterpriseTypename { get => enterpriseTypename; set => enterpriseTypename = value; }

        /// <summary>
        /// Add a new Enterprises in the collection
        /// </summary>
        /// <pdGenerated>Default Add</pdGenerated>
        public void AddEnterprises(Enterprises newEnterprises)
        {
            if (newEnterprises == null)
                return;
            if (this.enterprises == null)
                this.enterprises = new System.Collections.Generic.List<Enterprises>();
            if (!this.enterprises.Contains(newEnterprises))
            {
                this.enterprises.Add(newEnterprises);
                newEnterprises.EnterpriseType = this;
            }
        }

        /// <summary>
        /// Remove an existing Enterprises from the collection
        /// </summary>
        /// <pdGenerated>Default Remove</pdGenerated>
        public void RemoveEnterprises(Enterprises oldEnterprises)
        {
            if (oldEnterprises == null)
                return;
            if (this.enterprises != null)
                if (this.enterprises.Contains(oldEnterprises))
                {
                    this.enterprises.Remove(oldEnterprises);
                    oldEnterprises.EnterpriseType = null;
                }
        }

        /// <summary>
        /// Remove all instances of Enterprises from the collection
        /// </summary>
        /// <pdGenerated>Default removeAll</pdGenerated>
        public void RemoveAllEnterprises()
        {
            if (enterprises != null)
            {
                System.Collections.ArrayList tmpEnterprises = new System.Collections.ArrayList();
                foreach (Enterprises oldEnterprises in enterprises)
                    tmpEnterprises.Add(oldEnterprises);
                enterprises.Clear();
                foreach (Enterprises oldEnterprises in tmpEnterprises)
                    oldEnterprises.EnterpriseType = null;
                tmpEnterprises.Clear();
            }
        }

    }
}