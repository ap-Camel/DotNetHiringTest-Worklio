using DotNetHiringTst_Worklio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DotNetHiringTst_Worklio
{
    public partial class Countries : System.Web.UI.UserControl
    {

        public class strings
        {
            public string name { get; set; }
            // public string capital { get; set; }
            public string cioc { get; set; }
        }

        private static HttpClient client;
        public event EventHandler OnButton1Click;
        public List<strings> gridList;
        List<CountryModel> list;

        public Countries()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44357/api/");
            gridList = new List<strings>();
            list = new List<CountryModel>();
        }
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Cache["gridList"] != null && Cache["list"] != null)
            {
                list = (List<CountryModel>)Cache["list"];
                gridList = (List<strings>)Cache["gridList"];
                GridView1.DataSource = gridList;
                GridView1.DataBind();

            } else
            {
                if(!IsPostBack)
                {
                    // List<CountryModel> list = new List<CountryModel>();
                    // HttpClient client = new HttpClient();
                    var apiCall = client.GetAsync("Countries");
                    apiCall.Wait();

                    var response = apiCall.Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var data = response.Content.ReadAsAsync<List<CountryModel>>();
                        data.Wait();
                        list = data.Result;
                        // countries = response.Content.ReadAsAsync<List<CountryModel>>();
                    }

                    gridList.Clear();
                    foreach (CountryModel country in list)
                    {
                        gridList.Add(new strings { name = country.name.common, cioc = country.cioc });
                    }

                    Cache["gridList"] = gridList;
                    Cache["list"] = list;

                    GridView1.DataSource = gridList;
                    GridView1.DataBind();
                }
            }


                //Button btn = new Button();
                //btn.Text = list[1].name.common;
                // btn.Click = OnButton1Click;

                // countriesSection.Controls.Add(btn);

                //string controls = ""; 
                //foreach(CountryModel country in countries)
                //{
                //    controls += $"<p id='{country.name.common}' class='country' runat='server' >{country.name.common}</p>";
                //}

                //Label lbl = new Label();
                //lbl.Text = controls;

                //holder.Controls.Add(lbl);

                //ListView1.DataSource = countries;
                //ListView1.DataBind();


                //GridView1.DataSource = countries;
                //GridView1.DataBind();
            
        }

        protected void handleCountryClicked(object sender, EventArgs e)
        {
            // ListView1.SelectedIndexChanged(null, null);
            if (OnButton1Click != null)
            {
                OnButton1Click(this, null);
            }
            // show.Text = "yes it was clicked";
        }

        protected void GridView1_Sorting(object sender, GridViewSortEventArgs e)
        {
            gridList = gridList.OrderBy(x => x.name).ToList();
            GridView1.DataSource = gridList;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            int i = GridView1.SelectedIndex;
            string name = gridList[i].name;
            CountryModel selected = list.Where(x => x.name.common == name).FirstOrDefault();
            List<string> temp = new List<string>();

            //foreach(string s in selected.borders)
            //{
            //    CountryModel country = list.Where(x => x.cioc.ToUpper() == s).FirstOrDefault<CountryModel>();
            //    temp.Add(country.name.common);
            //}

            if(selected.borders != null)
            {
                foreach (string s in selected.borders)
                {
                    var apiCall = client.GetAsync($"Countries/{s}");
                    apiCall.Wait();

                    var response = apiCall.Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var data = response.Content.ReadAsAsync<CountryModel>();
                        data.Wait();
                        temp.Add(data.Result.name.common);
                    }
                }
            }

            lblCapital.Text = "Capital: " + selected.capital[0];
            lblBorders.Text = "list of bordering countries";
            bulletList.DataSource = temp;
            bulletList.DataBind();
        }
    }
}