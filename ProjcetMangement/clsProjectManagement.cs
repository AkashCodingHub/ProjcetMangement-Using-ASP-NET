using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProjcetMangement
{
    public class clsProjectManagement
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-RRP3MVI\\SQLEXPRESS;Initial Catalog=ProjectManagement;Integrated Security=True;");
        private string text1;
        private string text2;
        private string text3;

        public int RegistrationId { get; set; }

        public int PositionId { get; set; } 

        public string Name { get; set; }   
        
        public string UserType { get; set; }    

        public string Email {  get; set; }  

        public string Password { get; set; }    

        public  string Phone {  get; set; }    

        public int CountryId { get; set; }  

        public int CityId { get; set; }

        public int StateId { get; set; }    

        public string PositionName { get; set; }    

        public int ProjectId { get; set; }

        public string ProjectName { get; set; } 

        public string Technology { get; set; }  

        public int TechnologyId { get; set; }

        public int TechnologyName { get; set; }

        public string StartDate { get; set; } 

        public string EndDate { get; set; } 

        public int AssignBy { get; set; }

        public int AdminId {  get; set; }   

        public string StatusName { get; set; }  

        public int ManagerId { get; set; }  

        public int AssignTo { get; set; }

        public  DateTime Date { get; set; }
        public object AssignId { get; internal set; }
        public string Status { get; set; }

        public int StatusId { get;  set; }      

        public int ItreationId {  get; set; }
        public int RegistrationIdMA { get;  set; }
       
        public string Paid { get;  set; }

       public string UnPaid { get; set; }
        public int Amount { get;  set; }
        public string Assign { get;  set; }
        public string Pending { get; set; }

        public clsProjectManagement(clsProjectManagement P)
        {
            RegistrationId = P.RegistrationId;  
            PositionId = P.PositionId;  
            Name = P.Name;  
            Email = P.Email;    
            Password = P.Password;  
            Phone = P.Phone;    
            CountryId = P.CountryId;    
            CityId = P.CityId;  
            StateId = P.StateId;    
            PositionName = P.PositionName;  
            Email = P.Email;    
            Password = P.Password;  
            TechnologyId = P.TechnologyId;  
            TechnologyName = P.TechnologyName; 
            StartDate = P.StartDate;    
            EndDate = P.EndDate;    
            Technology = P.Technology;  
            AssignBy = P.AssignBy;  
            AssignTo = P.AssignTo;  
            Date = P.Date;
            StatusName = P.StatusName;  
        }

        //public clsProjectManagement(int positionid,string name,string email, string password)
        //{
        //    PositionId = positionid;
        //    Name = name;
        //    Email = email;
        //    Password = password;
        //}

        public clsProjectManagement()
        {
        }

        public clsProjectManagement(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
        
        }

        public DataTable Login()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ProjectManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "Login");
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@Password", Password);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
       

        public DataTable ShowPositionAPB()
        {
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("ProjectManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "ShowPositionAPB");
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
        }

        public DataTable FetchCountry()
        {
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("ProjectManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "FetchCountry");
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
        }

        public DataTable FetchState()
        {
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("ProjectManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "FetchState");
            cmd.Parameters.AddWithValue("@CountryId", CountryId);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
        }

        public DataTable TechnologyRegister()
        {
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("ProjectManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag","TechnologyRegister");
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
        }

        public void EmployeeRegister()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ProjectManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "EmployeeRegister");
            cmd.Parameters.AddWithValue("@PositionId", PositionId);
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@Phone", Phone);
            cmd.Parameters.AddWithValue("@CountryId", CountryId);
            cmd.Parameters.AddWithValue("@StateId", StateId);
            cmd.Parameters.AddWithValue("@Password", Password);
            cmd.ExecuteNonQuery();
            con.Close();

        }

        public void ProjectRegister()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ProjectManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "ProjectRegister");
            //cmd.Parameters.AddWithValue("@ProjectId", ProjectId);
            cmd.Parameters.AddWithValue("@ProjectName", ProjectName);
            cmd.Parameters.AddWithValue("@TechnologyId", TechnologyId);
            cmd.Parameters.AddWithValue("@StartDate", StartDate);
            cmd.Parameters.AddWithValue("@EndDate", EndDate);
            cmd.Parameters.AddWithValue("@Amount", Amount);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void AssignToManager(int RegistrationId, int ProjectId,int RegistrationIdAd)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ProjectManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "AssignToManager");
            cmd.Parameters.AddWithValue("@ProjectId", ProjectId);
            cmd.Parameters.AddWithValue("@AssignBy", RegistrationIdAd);
            cmd.Parameters.AddWithValue("@AssignTo", RegistrationId);
            cmd.Parameters.AddWithValue("@IterationId", 2);
            cmd.Parameters.AddWithValue("@Status", Assign);
            cmd.Parameters.AddWithValue("@Date", DateTime.Now);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void AssignToTeamLeader(int RegistrationIdMA)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ProjectManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "AssignToTeamLeader");
            cmd.Parameters.AddWithValue("@ProjectId", ProjectId);
            cmd.Parameters.AddWithValue("@AssignBy", RegistrationIdMA);
            cmd.Parameters.AddWithValue("@AssignTo", RegistrationId);
            cmd.Parameters.AddWithValue("@IterationId", 3);
            cmd.Parameters.AddWithValue("@Date", DateTime.Now);
            cmd.Parameters.AddWithValue("@Status", UnPaid);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void AssignPayment(int RegistrationIdADC, int ProjectId)
        {
            Status = Paid;
            con.Open();
            SqlCommand cmd = new SqlCommand("ProjectManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "AssignPayment");
            cmd.Parameters.AddWithValue("@ProjectId", ProjectId);
            cmd.Parameters.AddWithValue("@RegistrationId", RegistrationIdADC);
            cmd.Parameters.AddWithValue("@Status",Paid);
            cmd.Parameters.AddWithValue("@Date",DateTime.Now);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataTable AllrecordAdminPage()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ProjectManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "AllrecordAdminPage");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();

        }

        public DataTable fetchManagerDetails(int RegistrationId)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ProjectManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag","fetchManagerDetails");
            cmd.Parameters.AddWithValue("@RegistrationId", RegistrationId);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;

        }

        public DataTable fetchTeamLeaderDetails(int RegistrationId)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ProjectManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag","fetchTeamLeaderDetails");
            cmd.Parameters.AddWithValue("@RegistrationId",RegistrationId);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;

        }

        public DataTable ProjectFetchToTeamLeader()
        {
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("ProjectManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "ProjectFetchToTeamLeader");
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;

        }


        public DataTable fetchManager()
        {
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("ProjectManagement",con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "fetchManager");
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
          
        }

        public DataTable fetchTeamLeader()
        {
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("ProjectManagement",con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "fetchTeamLeader");
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
    
        }

        public void UpdateIteration(int RegistrationIdTA)
        {
            con.Open();
            Status = UnPaid;
            SqlCommand cmd = new SqlCommand("ProjectManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "UpdateIterations");
            cmd.Parameters.AddWithValue("@ProjectId", ProjectId);
            cmd.Parameters.AddWithValue("@AssignId",RegistrationIdTA);
            cmd.Parameters.AddWithValue("@Date", DateTime.Now);
            cmd.ExecuteNonQuery();  
            con.Close();
        }

        public DataTable CompletedProject()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ProjectManagement", con);
            DataTable dt = new DataTable();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "CompletedProject");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            adpt.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable CompletePayment()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ProjectManagement", con);
            DataTable dt = new DataTable();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "CompletePayment");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            adpt.Fill(dt);
            con.Close();
            return dt;
        }



        public DataTable ShowProject()
        {
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("ProjectManagement", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "ShowProject");
            cmd.Parameters.AddWithValue("@ProjectId", ProjectId);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
        
    }


    }
}

