﻿using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Text;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;

public partial class EditAmenitiesAndAttractions : ClosedPage
{
    private bool ifadd;

    protected System.Data.SqlClient.SqlDataAdapter PropertiesAdapter;
    protected System.Data.SqlClient.SqlDataAdapter PropertyTypesAdapter;
    protected System.Data.SqlClient.SqlDataAdapter MinimumNightlyRentalTypesAdapter;
    protected System.Data.SqlClient.SqlDataAdapter GetAdministrators;
    protected System.Data.SqlClient.SqlDataAdapter StateProvincesAdapter;
    protected System.Data.SqlClient.SqlDataAdapter CitiesAdapter;
    protected System.Data.SqlClient.SqlDataAdapter CountriesAdapter;
    protected System.Data.SqlClient.SqlDataAdapter RegionsAdapter;
    protected System.Data.SqlClient.SqlDataAdapter GetLocationInfo;
    protected System.Data.SqlClient.SqlDataAdapter AttractionsAdapter;
    protected System.Data.SqlClient.SqlDataAdapter AmenitiesAdapter;
    protected System.Data.SqlClient.SqlDataAdapter PropertiesAmenitiesAdapter;
    protected System.Data.SqlClient.SqlDataAdapter PropertiesAttractionsAdapter;
    protected System.Data.SqlClient.SqlDataAdapter FurnitureItemsAdapter;
    protected System.Data.SqlClient.SqlDataAdapter DistancesAdapter;
    protected System.Data.SqlClient.SqlDataAdapter RoomsAdapter;
    protected System.Data.SqlClient.SqlDataAdapter PaymentMethodsAdapter;
    protected System.Data.SqlClient.SqlDataAdapter RatesAdapter;
    protected System.Data.SqlClient.SqlDataAdapter FurnitureAdapter;
    protected System.Data.SqlClient.SqlDataAdapter PropertiesPaymentMethodsAdapter;
    protected System.Data.SqlClient.SqlDataAdapter AttractionsDistancesAdapter;
    protected System.Data.SqlClient.SqlDataAdapter RoomFurnitureItemsAdapter;
    protected Vacations.PropertiesDataset PropertiesSet;
    protected System.Web.UI.WebControls.Label Label22;
    protected System.Web.UI.WebControls.Label Label14;
    protected System.Web.UI.WebControls.Label Label2;
    protected System.Web.UI.WebControls.Label Label3;
    protected System.Web.UI.WebControls.Label Label5;
    protected System.Web.UI.WebControls.Label Label7;
    protected System.Web.UI.WebControls.Label Label9;
    protected System.Web.UI.WebControls.Label Label11;
    protected System.Web.UI.WebControls.Label Label13;
    protected System.Web.UI.WebControls.Label Label15;
    protected System.Web.UI.WebControls.Label Label18;
    protected System.Web.UI.WebControls.Label Label20;
    protected System.Web.UI.WebControls.Label Label25;
    protected System.Web.UI.WebControls.Label Label34;
    protected System.Web.UI.WebControls.Label Label35;
    protected System.Web.UI.WebControls.Label Label56;
    protected System.Web.UI.WebControls.Label Label57;
    protected System.Web.UI.WebControls.Label Label58;
    protected System.Web.UI.WebControls.Label Label59;
    protected System.Web.UI.WebControls.Label Label60;
    protected Vacations.PropertyTypesDataset PropertyTypesSet;
    protected System.Data.SqlClient.SqlCommand sqlSelectCommand6;
    protected Vacations.MinimumNightlyRentalTypesDataset MinimumNightlyRentalTypesSet;
    protected System.Web.UI.WebControls.Label Label62;
    protected System.Web.UI.WebControls.Label Label61;
    protected Vacations.CountriesDataset CountriesSet;
    protected System.Web.UI.WebControls.Label Label63;
    protected System.Web.UI.WebControls.Label Label64;
    protected System.Web.UI.WebControls.Label Label65;
    protected System.Web.UI.WebControls.Label Label66;
    protected System.Web.UI.WebControls.Label Label67;
    protected System.Web.UI.WebControls.Label Label68;
    protected System.Web.UI.WebControls.Label Label69;
    protected System.Web.UI.WebControls.Label Label70;
    protected System.Web.UI.WebControls.Label Label71;
    protected System.Web.UI.WebControls.Label Label16;
    protected Vacations.UserDataset UserSet;
    protected Vacations.CitiesDataset CitiesSet;
    protected Vacations.StateProvincesDataset StateProvincesSet;
    protected System.Web.UI.WebControls.Label Label1;
    protected System.Web.UI.WebControls.Label Label4;
    protected Vacations.RegionsDataset RegionsSet;
    protected System.Data.SqlClient.SqlCommand sqlSelectCommand8;
    protected Vacations.FullLocationDataset FullLocationSet;
    protected System.Data.SqlClient.SqlCommand sqlSelectCommand7;
    protected System.Data.SqlClient.SqlCommand sqlInsertCommand1;
    protected System.Data.SqlClient.SqlCommand sqlSelectCommand3;
    protected System.Data.SqlClient.SqlCommand sqlInsertCommand4;
    protected Vacations.AttractionsDataset AttractionsSet;
    protected Vacations.AmenitiesDataset AmenitiesSet;
    protected System.Data.SqlClient.SqlCommand sqlSelectCommand4;
    protected System.Data.SqlClient.SqlCommand sqlInsertCommand5;
    protected Vacations.PropertiesAttractionsDataset PropertiesAttractionsSet;
    protected Vacations.PropertiesAmenitiesDataset PropertiesAmenitiesSet;
    protected System.Data.SqlClient.SqlCommand sqlSelectCommand12;
    protected System.Data.SqlClient.SqlCommand sqlSelectCommand13;
    protected System.Web.UI.WebControls.Label Label6;
    protected System.Web.UI.WebControls.Label Label8;
    protected System.Web.UI.WebControls.Label Label10;
    protected System.Web.UI.WebControls.Label Label12;
    protected System.Web.UI.WebControls.Label Label17;
    protected System.Web.UI.WebControls.Label Label19;
    protected System.Data.SqlClient.SqlCommand sqlSelectCommand11;
    protected System.Data.SqlClient.SqlCommand sqlSelectCommand9;
    protected System.Data.SqlClient.SqlCommand sqlSelectCommand2;
    protected System.Web.UI.WebControls.Label ShowAddressLabel;
    protected System.Data.SqlClient.SqlCommand sqlSelectCommand14;
    protected Vacations.FurnitureItemsDataset FurnitureItemsSet;
    protected System.Data.SqlClient.SqlCommand sqlSelectCommand15;
    protected Vacations.DistancesDataset DistancesSet;
    protected System.Data.SqlClient.SqlCommand sqlCommand1;
    protected Vacations.RatesDataset RatesSet;
    protected Vacations.PaymentMethodsDataset PaymentMethodsSet;
    protected System.Data.SqlClient.SqlCommand sqlSelectCommand16;
    protected Vacations.RoomsDataset RoomsSet;
    protected Vacations.FurnitureDataset FurnitureSet;
    protected System.Data.SqlClient.SqlCommand sqlSelectCommand17;
    protected System.Data.SqlClient.SqlCommand sqlSelectCommand18;
    protected Vacations.PropertiesPaymentMethodsDataset PropertiesPaymentMethodsSet;
    protected System.Data.SqlClient.SqlCommand sqlCommand2;
    protected Vacations.RoomFurnitureItemsDataset RoomFurnitureItemsSet;
    protected System.Data.SqlClient.SqlCommand sqlSelectCommand19;
    protected System.Data.SqlClient.SqlCommand sqlInsertCommand2;
    protected System.Data.SqlClient.SqlCommand sqlSelectCommand20;
    //protected System.Data.SqlClient.SqlConnection Connection;
    protected Vacations.AttractionsDistancesDataset AttractionsDistancesSet1;
    protected Vacations.AttractionsDistancesDataset AttractionsDistancesSet2;
    protected System.Data.SqlClient.SqlCommand sqlSelectCommand5;
    protected System.Data.SqlClient.SqlCommand sqlSelectCommand10;
    protected System.Data.SqlClient.SqlCommand sqlSelectCommand1;

    public string jsCity = "";
    public string jsState = "";
    public string jsCounty = "";
    public string jsCountry = "";
    public string jsRegion = "";
    public string jsProp = "";
    public string jsPropStr = "";

    protected void Page_Load(object sender, System.EventArgs e)
    {
        System.Data.SqlClient.SqlCommandBuilder builder = new System.Data.SqlClient.SqlCommandBuilder(PropertiesAdapter);
        System.Data.SqlClient.SqlCommandBuilder builder2 = new System.Data.SqlClient.SqlCommandBuilder(PropertiesAmenitiesAdapter);
        System.Data.SqlClient.SqlCommandBuilder builder3 = new System.Data.SqlClient.SqlCommandBuilder(PropertiesAttractionsAdapter);
        System.Data.SqlClient.SqlCommandBuilder builder4 = new System.Data.SqlClient.SqlCommandBuilder(RatesAdapter);
        System.Data.SqlClient.SqlCommandBuilder builder5 = new System.Data.SqlClient.SqlCommandBuilder(PropertiesPaymentMethodsAdapter);
        System.Data.SqlClient.SqlCommandBuilder builder6 = new System.Data.SqlClient.SqlCommandBuilder(RoomsAdapter);
        System.Data.SqlClient.SqlCommandBuilder builder7 = new System.Data.SqlClient.SqlCommandBuilder(RoomFurnitureItemsAdapter);

        //string connectionstring = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        //CommonFunctions.Connection.ConnectionString = connectionstring;

        //if (CommonFunctions.Connection.State == System.Data.ConnectionState.Closed)
        //CommonFunctions.Connection.Open ();

        //lock (CommonFunctions.Connection)
        RegionsAdapter.Fill(RegionsSet);
        //lock (CommonFunctions.Connection)
        AmenitiesAdapter.Fill(AmenitiesSet);
        //lock (CommonFunctions.Connection)
        AttractionsAdapter.Fill(AttractionsSet);
        //lock (CommonFunctions.Connection)
        PropertyTypesAdapter.Fill(PropertyTypesSet);
        //lock (CommonFunctions.Connection)
        MinimumNightlyRentalTypesAdapter.Fill(MinimumNightlyRentalTypesSet);
        //lock (CommonFunctions.Connection)
        FurnitureItemsAdapter.Fill(FurnitureItemsSet);
        //lock (CommonFunctions.Connection)
        DistancesAdapter.Fill(DistancesSet);
        //lock (CommonFunctions.Connection)
        PaymentMethodsAdapter.Fill(PaymentMethodsSet);

        if (propertyid == -1)
        {
            SubmitButton.Text = "Next Step";

            object maxid;
            using (SqlConnection connection = CommonFunctions.GetConnection())
            {
                connection.Open();
                System.Data.SqlClient.SqlCommand getmaxid = new System.Data.SqlClient.SqlCommand(
                    "SELECT MAX(ID) FROM Properties", connection);

                maxid = getmaxid.ExecuteScalar();
                connection.Close();
            }

            if (maxid is DBNull)
                propertyid = 1;
            else
                propertyid = (int)maxid + 1;

            System.Data.DataRow newproperty = PropertiesSet.Tables["Properties"].NewRow();

            newproperty["ID"] = propertyid;
            newproperty["UserID"] = userid;

            newproperty["Name"] = "";
            newproperty["TypeID"] = PropertyTypesSet.Tables["PropertyTypes"].Rows[0]["ID"];
            foreach (System.Data.DataRow datarow in PropertyTypesSet.Tables["PropertyTypes"].Rows)
                if ((datarow["Name"] is string) && ((string)datarow["Name"] != "Other (please specify)"))
                    newproperty["TypeID"] = datarow["ID"];

            newproperty["Address"] = "";
            newproperty["IfShowAddress"] = false;

            newproperty["NumBedrooms"] = 0;
            newproperty["NumBaths"] = 0;
            newproperty["NumSleeps"] = 0;
            newproperty["MinimumNightlyRentalID"] = MinimumNightlyRentalTypesSet.Tables["MinimumNightlyRentalTypes"].Rows[0]["ID"];

            newproperty["NumTVs"] = 0;
            newproperty["NumVCRs"] = 0;
            newproperty["NumCDPlayers"] = 0;

            newproperty["IfMoreThan7PhotosAllowed"] = false;
            newproperty["IfFinished"] = false;
            newproperty["IfApproved"] = false;  //changed to allow admin to review

            newproperty["RatesTable"] = false;
            newproperty["PricesCurrency"] = "USD";
            newproperty["CheckIn"] = "Check with Owner";
            newproperty["CheckOut"] = "Check with Owner";

            newproperty["DateAdded"] = DateTime.Now;
            newproperty["DateStartViewed"] = DateTime.Now;

            PropertiesSet.Tables["Properties"].Rows.Add(newproperty);

            //lock (CommonFunctions.Connection)
            PropertiesAdapter.Update(PropertiesSet);

            Response.Redirect(CommonFunctions.PrepareURL("EditAmenitiesAndAttractions.aspx?" + Request.QueryString.ToString() +
                "&PropertyID=" + propertyid.ToString() + "&IfAdd=1"), false);

            return;
        }

        ifadd = (Request.Params["IfAdd"] != null);

        PropertiesAdapter.SelectCommand.Parameters["@PropertyID"].Value = propertyid;

        //lock (CommonFunctions.Connection)
        if (PropertiesAdapter.Fill(PropertiesSet) < 1)
            Response.Redirect(backlinkurl);

        if ((userid != (int)PropertiesSet.Tables["Properties"].Rows[0]["UserID"]) && !AuthenticationManager.IfAdmin)
            Response.Redirect(CommonFunctions.PrepareURL("Login.aspx?BackLink=" + HttpUtility.UrlEncode(Request.Url.ToString())));

        PropertiesAmenitiesSet.Clear();
        PropertiesAmenitiesAdapter.SelectCommand.Parameters["@PropertyID"].Value = propertyid;
        //lock (CommonFunctions.Connection)
        PropertiesAmenitiesAdapter.Fill(PropertiesAmenitiesSet);

        PropertiesAttractionsSet.Clear();
        PropertiesAttractionsAdapter.SelectCommand.Parameters["@PropertyID"].Value = propertyid;
        //lock (CommonFunctions.Connection)
        PropertiesAttractionsAdapter.Fill(PropertiesAttractionsSet);

        RoomsSet.Clear();
        RoomsAdapter.SelectCommand.Parameters["@PropertyID"].Value = propertyid;
        //lock (CommonFunctions.Connection)
        RoomsAdapter.Fill(RoomsSet);

        RatesSet.Clear();
        RatesAdapter.SelectCommand.Parameters["@PropertyID"].Value = propertyid;
        //lock (CommonFunctions.Connection)
        RatesAdapter.Fill(RatesSet);

        PropertiesPaymentMethodsSet.Clear();
        PropertiesPaymentMethodsAdapter.SelectCommand.Parameters["@PropertyID"].Value = propertyid;
        //lock (CommonFunctions.Connection)
        PropertiesPaymentMethodsAdapter.Fill(PropertiesPaymentMethodsSet);

        RoomsSet.Clear();
        RoomsAdapter.SelectCommand.Parameters["@PropertyID"].Value = propertyid;
        //lock (CommonFunctions.Connection)
        RoomsAdapter.Fill(RoomsSet);

        RoomFurnitureItemsSet.Clear();
        RoomFurnitureItemsAdapter.SelectCommand.Parameters["@PropertyID"].Value = propertyid;
        //lock (CommonFunctions.Connection)
        RoomFurnitureItemsAdapter.Fill(RoomFurnitureItemsSet);

        AttractionsDistancesSet1.Clear();
        AttractionsDistancesSet2.Clear();
        AttractionsDistancesAdapter.SelectCommand.Parameters["@PropertyID"].Value = propertyid;
        //lock (CommonFunctions.Connection)
        AttractionsDistancesAdapter.Fill(AttractionsDistancesSet1);
        //lock (CommonFunctions.Connection)
        AttractionsDistancesAdapter.Fill(AttractionsDistancesSet2);

        int num;
        num = 1;
        foreach (DataRow datarow in new Snapshot(AttractionsDistancesSet1.Tables["Attractions"].Rows))
        {
            if (num % 2 == 0)
                AttractionsDistancesSet1.Tables["Attractions"].Rows.Remove(datarow);
            num++;
        }

        num = 1;
        foreach (DataRow datarow in new Snapshot(AttractionsDistancesSet2.Tables["Attractions"].Rows))
        {
            if (num % 2 == 1)
                AttractionsDistancesSet2.Tables["Attractions"].Rows.Remove(datarow);
            num++;
        }

        MoreThan7PhotosAllowed.Visible = AuthenticationManager.IfAdmin;
        MoreThan7PhotosAllowedLabel.Visible = AuthenticationManager.IfAdmin;

        if (!IsPostBack)
        {
            DataBind();

            PropertyName.Text = CommonFunctions.DecodeInput(PropertyName.Text);
            txtPropName.Text = CommonFunctions.DecodeInput(txtPropName.Text);
            AddressLocation.Text = CommonFunctions.DecodeInput(AddressLocation.Text);
            VirtualTour.Text = CommonFunctions.DecodeInput(VirtualTour.Text);
            Description.Text = CommonFunctions.DecodeInput(Description.Text);
            Amenities.Text = CommonFunctions.DecodeInput(Amenities.Text);
            LocalAttractions.Text = CommonFunctions.DecodeInput(LocalAttractions.Text);
            CancellationPolicy.Text = CommonFunctions.DecodeInput(CancellationPolicy.Text);
            DepositRequired.Text = CommonFunctions.DecodeInput(DepositRequired.Text);

            foreach (ListItem item in AmenitiesList.Items)
            {
                item.Selected = false;
                foreach (DataRow datarow in PropertiesAmenitiesSet.Tables["PropertiesAmenities"].Rows)
                    if ((int)datarow["AmenityID"] == Convert.ToInt32(item.Value))
                    {
                        item.Selected = true;
                        break;
                    }
            }

            if (RoomsSet.Tables["RoomInfo"].Rows.Count > 0)
            {
                RoomAActive.Checked = true;
                RoomATitle.Text = (string)RoomsSet.Tables["RoomInfo"].Rows[0]["RoomTitle"];
                ProcessFurnitureList(RoomAList, (int)RoomsSet.Tables["RoomInfo"].Rows[0]["ID"]);
            }
            if (RoomsSet.Tables["RoomInfo"].Rows.Count > 1)
            {
                RoomBActive.Checked = true;
                RoomBTitle.Text = (string)RoomsSet.Tables["RoomInfo"].Rows[1]["RoomTitle"];
                ProcessFurnitureList(RoomBList, (int)RoomsSet.Tables["RoomInfo"].Rows[1]["ID"]);
            }
            if (RoomsSet.Tables["RoomInfo"].Rows.Count > 2)
            {
                RoomCActive.Checked = true;
                RoomCTitle.Text = (string)RoomsSet.Tables["RoomInfo"].Rows[2]["RoomTitle"];
                ProcessFurnitureList(RoomCList, (int)RoomsSet.Tables["RoomInfo"].Rows[2]["ID"]);
            }
            if (RoomsSet.Tables["RoomInfo"].Rows.Count > 3)
            {
                RoomDActive.Checked = true;
                RoomDTitle.Text = (string)RoomsSet.Tables["RoomInfo"].Rows[3]["RoomTitle"];
                ProcessFurnitureList(RoomDList, (int)RoomsSet.Tables["RoomInfo"].Rows[3]["ID"]);
            }
            if (RoomsSet.Tables["RoomInfo"].Rows.Count > 4)
            {
                RoomEActive.Checked = true;
                RoomETitle.Text = (string)RoomsSet.Tables["RoomInfo"].Rows[4]["RoomTitle"];
                ProcessFurnitureList(RoomEList, (int)RoomsSet.Tables["RoomInfo"].Rows[4]["ID"]);
            }
        }

        LocationError.Visible = false;
        Page.Header.Controls.Add(new LiteralControl("<script src='/scripts/countryStateCityBack5.js?1=1' type='text/javascript'></script>"));

        if (Master.FindControl("BodyTag") is HtmlGenericControl)
        {
            HtmlGenericControl body = (HtmlGenericControl)Master.FindControl("BodyTag");
            body.Attributes["onload"] = "ProcessValidators(); InitializeDropdowns();";
        }
        FillPropTypeJS();
        FillCountyJS();
    }
    public void FillCountyJS()
    {
        string script = "<script language=\"javascript\" type=\"text/javascript\">\n ";
        //add county/stateid rel

        DBConnection obj = new DBConnection();
        DataTable dt = new DataTable();
        try
        {
            dt = VADBCommander.CountyNameList();
            //countynames
            script += "var numcounties = " + dt.Rows.Count.ToString() + ";\n";
            script += "var counties = new Array (\"";
            foreach (DataRow datarow in dt.Rows)
            {
                if (datarow["countyname"] is DBNull)
                    script += "0";
                else
                    script += datarow["countyname"].ToString();
                script += "\", \"";
            }
            if (dt.Rows.Count > 0)
                script = script.Remove(script.Length - 3, 3);
            script += ");\n";

            //county-stateids
            script += "var countiesstates = new Array (";
            foreach (DataRow datarow in dt.Rows)
            {
                if (datarow["stateid"] is DBNull)
                    script += "0";
                else
                    script += datarow["stateid"].ToString();
                script += ", ";
            }
            if (dt.Rows.Count > 0)
                script = script.Remove(script.Length - 2, 2);
            script += ");\n";


            //countyids
            script += "var countyids = new Array (";
            foreach (DataRow datarow in dt.Rows)
            {
                if (datarow["id"] is DBNull)
                    script += "0";
                else
                    script += datarow["id"].ToString();
                script += ", ";
            }
            if (dt.Rows.Count > 0)
                script = script.Remove(script.Length - 2, 2);
            script += ");\n";


            dt = VADBCommander.CountyDistinctList();

            //county-city ids
            script += "var countycityids = new Array (";
            foreach (DataRow datarow in dt.Rows)
            {
                if (datarow["cityid"] is DBNull)
                    script += "0";
                else
                    script += datarow["cityid"].ToString();
                script += ", ";
            }
            if (dt.Rows.Count > 0)
                script = script.Remove(script.Length - 2, 2);
            script += ");\n";

            //county-city names
            script += "var countycitycountynames = new Array (\"";
            foreach (DataRow datarow in dt.Rows)
            {
                if (datarow["county"] is DBNull)
                    script += "0";
                else
                    script += datarow["county"].ToString();
                script += "\", \"";
            }
            if (dt.Rows.Count > 0)
                script = script.Remove(script.Length - 3, 3);
            script += ");\n";


            script += "var countycitycountyids = new Array (";
            foreach (DataRow datarow in dt.Rows)
            {
                if (datarow["id"] is DBNull)
                    script += "0";
                else
                    script += datarow["id"].ToString();
                script += ", ";
            }
            if (dt.Rows.Count > 0)
                script = script.Remove(script.Length - 2, 2);
            script += ");\n";

            script += "</script>\n";
        }

        catch (Exception ex) { lblInfo.Text = ex.Message; }
        finally { obj.CloseConnection(); }
        divCounties.InnerHtml = script;
    }
    public void FillPropTypeJS()
    {
        string script = "<script language=\"javascript\" type=\"text/javascript\">\n ";
        //add county/stateid rel
        DBConnection obj = new DBConnection();
        DataTable dt = new DataTable();
        try
        {

            dt = obj.spGetCategories();

            //countynames
            script += "var priTypes = new Array (\"";
            foreach (DataRow datarow in dt.Rows)
            {
                if (datarow["categorytypes"] is DBNull)
                    script += "0";
                else
                    script += datarow["categorytypes"].ToString();
                script += "\", \"";
            }
            if (dt.Rows.Count > 0)
                script = script.Remove(script.Length - 3, 3);
            script += ");\n";

            //county-stateids
            script += "var priTypeIDs = new Array (";
            foreach (DataRow datarow in dt.Rows)
            {
                if (datarow["id"] is DBNull)
                    script += "0";
                else
                    script += datarow["id"].ToString();
                script += ", ";
            }
            if (dt.Rows.Count > 0)
                script = script.Remove(script.Length - 2, 2);
            script += ");\n";

            script += "</script>\n";
        }

        catch (Exception ex) { lblInfo.Text = ex.Message; }
        finally { obj.CloseConnection(); }
        divPriTypes.InnerHtml = script;
    }
    public string DropDownScript()
    {
        StringBuilder script = new StringBuilder();
        DataTable dt = new DataTable();
        DBConnection obj = new DBConnection();
        lblInfo.Text = propertyid.ToString() + " id";
        //lock (CommonFunctions.Connection)
        CountriesAdapter.Fill(CountriesSet);
        //lock (CommonFunctions.Connection)
        StateProvincesAdapter.Fill(StateProvincesSet);
        //lock (CommonFunctions.Connection)
        CitiesAdapter.Fill(CitiesSet);

        script.Append("var numproptypes = " + PropertyTypesSet.Tables["PropertyTypes"].Rows.Count.ToString() + ";\n");

        script.Append("var Priproptypeids = new Array (");
        foreach (DataRow datarow in PropertyTypesSet.Tables["PropertyTypes"].Rows)
        {
            script.Append(datarow["category"].ToString());
            script.Append(", ");
        }
        if (PropertyTypesSet.Tables["PropertyTypes"].Rows.Count > 0)
            script.Remove(script.Length - 2, 2);
        script.Append(");\n");

        script.Append("var proptypeids = new Array (");
        foreach (DataRow datarow in PropertyTypesSet.Tables["PropertyTypes"].Rows)
        {
            script.Append(datarow["ID"].ToString());
            script.Append(", ");
        }
        if (PropertyTypesSet.Tables["PropertyTypes"].Rows.Count > 0)
            script.Remove(script.Length - 2, 2);
        script.Append(");\n");
        script.Append("var proptypestrs = new Array (");
        foreach (DataRow datarow in PropertyTypesSet.Tables["PropertyTypes"].Rows)
        {
            script.Append("\"");
            script.Append(datarow["Name"].ToString());
            script.Append("\", ");
        }
        if (PropertyTypesSet.Tables["PropertyTypes"].Rows.Count > 0)
            script.Remove(script.Length - 2, 2);
        script.Append(");\n");


        script.Append("var numregions = " + RegionsSet.Tables["Regions"].Rows.Count.ToString() + ";\n");
        script.Append("var regionids = new Array (");
        foreach (DataRow datarow in RegionsSet.Tables["Regions"].Rows)
        {
            script.Append(datarow["ID"].ToString());
            script.Append(", ");
        }
        if (RegionsSet.Tables["Regions"].Rows.Count > 0)
            script.Remove(script.Length - 2, 2);
        script.Append(");\n");
        script.Append("var regionstrs = new Array (");
        foreach (DataRow datarow in RegionsSet.Tables["Regions"].Rows)
        {
            script.Append("\"");
            script.Append(datarow["Region"].ToString());
            script.Append("\", ");
        }
        if (RegionsSet.Tables["Regions"].Rows.Count > 0)
            script.Remove(script.Length - 2, 2);
        script.Append(");\n");

        script.Append("var numcountries = " + CountriesSet.Tables["Countries"].Rows.Count.ToString() + ";\n");
        script.Append("var countryids = new Array (");
        foreach (DataRow datarow in CountriesSet.Tables["Countries"].Rows)
        {
            script.Append(datarow["ID"].ToString());
            script.Append(", ");
        }
        if (CountriesSet.Tables["Countries"].Rows.Count > 0)
            script.Remove(script.Length - 2, 2);
        script.Append(");\n");
        script.Append("var countryregions = new Array (");
        foreach (DataRow datarow in CountriesSet.Tables["Countries"].Rows)
        {
            if (datarow["RegionID"] is DBNull)
                script.Append("0");
            else
                script.Append(datarow["RegionID"].ToString());
            script.Append(", ");
        }
        if (CountriesSet.Tables["Countries"].Rows.Count > 0)
            script.Remove(script.Length - 2, 2);
        script.Append(");\n");
        script.Append("var countrystrs = new Array (");
        foreach (DataRow datarow in CountriesSet.Tables["Countries"].Rows)
        {
            script.Append("\"");
            script.Append(datarow["Country"].ToString());
            script.Append("\", ");
        }
        if (CountriesSet.Tables["Countries"].Rows.Count > 0)
            script.Remove(script.Length - 2, 2);
        script.Append(");\n");

        script.Append("var numprovinces = " + StateProvincesSet.Tables["StateProvinces"].Rows.Count.ToString() + ";\n");
        script.Append("var provinceids = new Array (");
        foreach (DataRow datarow in StateProvincesSet.Tables["StateProvinces"].Rows)
        {
            script.Append(datarow["ID"].ToString());
            script.Append(", ");
        }
        if (StateProvincesSet.Tables["StateProvinces"].Rows.Count > 0)
            script.Remove(script.Length - 2, 2);
        script.Append(");\n");
        script.Append("var provincecountries = new Array (");
        foreach (DataRow datarow in StateProvincesSet.Tables["StateProvinces"].Rows)
        {
            if (datarow["CountryID"] is DBNull)
                script.Append("0");
            else
                script.Append(datarow["CountryID"].ToString());
            script.Append(", ");
        }
        if (StateProvincesSet.Tables["StateProvinces"].Rows.Count > 0)
            script.Remove(script.Length - 2, 2);
        script.Append(");\n");
        script.Append("var provincestrs = new Array (");
        foreach (DataRow datarow in StateProvincesSet.Tables["StateProvinces"].Rows)
        {
            script.Append("\"");
            script.Append(datarow["StateProvince"].ToString());
            script.Append("\", ");
        }
        if (StateProvincesSet.Tables["StateProvinces"].Rows.Count > 0)
            script.Remove(script.Length - 2, 2);
        script.Append(");\n");


        //***********
        dt = VADBCommander.CityAndCountyList();

        script.Append("var numcities = " + dt.Rows.Count.ToString() + ";\n");
        script.Append("var cityids = new Array (");
        foreach (DataRow datarow in dt.Rows)
        {
            script.Append(datarow["ID"].ToString());
            script.Append(", ");
        }
        if (dt.Rows.Count > 0)
            script.Remove(script.Length - 2, 2);
        script.Append(");\n");
        script.Append("var cityprovinces = new Array (");
        foreach (DataRow datarow in dt.Rows)
        {
            if (datarow["StateProvinceID"] is DBNull)
                script.Append("0");
            else
                script.Append(datarow["StateProvinceID"].ToString());
            script.Append(", ");
        }
        if (dt.Rows.Count > 0)
            script.Remove(script.Length - 2, 2);
        script.Append(");\n");
        script.Append("var citystrs = new Array (");
        foreach (DataRow datarow in dt.Rows)
        {
            script.Append("\"");
            script.Append(datarow["City"].ToString());
            script.Append("\", ");
        }
        if (dt.Rows.Count > 0)
            script.Remove(script.Length - 2, 2);
        script.Append(");\n");

        script.Append("var cityCounty = new Array (");
        foreach (DataRow datarow in dt.Rows)
        {
            if (datarow["countyID"] is DBNull)
                script.Append("-1");
            else
                script.Append(datarow["countyID"].ToString());
            script.Append(", ");
        }
        if (dt.Rows.Count > 0)
            script.Remove(script.Length - 2, 2);
        script.Append(");\n");
        //*************************
        if (jsRegion != "")
        {
            script.Append("var initialregion = " + jsRegion + ";\n");
            script.Append("var initialcountry = " + jsCountry + ";\n");
            script.Append("var initialstateprovince = " + jsState + ";\n");
            script.Append("var initialcity = " + jsCity + ";\n");
            script.Append("var initialcounty = " + jsCounty + ";\n");
            script.Append("var initialproptype = -1;\n");
            script.Append("var initialpropstring = \"null\";\n");
        }
        else
            if (PropertiesSet.Tables["Properties"].Rows[0]["CityID"].ToString() != "")
        {
            dt = VADBCommander.CountiesByCityID(PropertiesSet.Tables["Properties"].Rows[0]["CityID"].ToString());
            if (dt.Rows.Count > 0)
                script.Append("var initialcounty = " + dt.Rows[0]["countyid"].ToString() + ";\n");
            else
                script.Append("var initialcounty = -1;\n");

            if ((PropertiesSet.Tables["Properties"].Rows[0]["CityID"] != null) &&
                !(PropertiesSet.Tables["Properties"].Rows[0]["CityID"] is DBNull))
            {
                GetLocationInfo.SelectCommand.Parameters["@CityID"].Value =
                    PropertiesSet.Tables["Properties"].Rows[0]["CityID"];
                //lock (CommonFunctions.Connection)
                if (GetLocationInfo.Fill(FullLocationSet) > 0)
                {
                    script.Append("var initialregion = " + FullLocationSet.Tables["Cities"].Rows[0]["RegionID"].ToString() + ";\n");
                    script.Append("var initialcountry = " + FullLocationSet.Tables["Cities"].Rows[0]["CountryID"].ToString() + ";\n");
                    script.Append("var initialstateprovince = " + FullLocationSet.Tables["Cities"].Rows[0]["StateProvinceID"].ToString() + ";\n");
                    script.Append("var initialcity = " + FullLocationSet.Tables["Cities"].Rows[0]["CityID"].ToString() + ";\n");
                    script.Append("var initialproptype = " + PropertiesSet.Tables["Properties"].Rows[0]["TypeID"].ToString() + ";\n");

                    dt = VADBCommander.PropertyTypeInd(PropertiesSet.Tables["Properties"].Rows[0]["TypeID"].ToString());
                    if (dt.Rows.Count > 0)
                        script.Append("var initialpropstring = \"" + dt.Rows[0]["name"].ToString() + "\";\n");
                }
                else
                {
                    script.Append("var initialregion = -1;\n");
                    script.Append("var initialcountry = -1;\n");
                    script.Append("var initialstateprovince = -1;\n");
                    script.Append("var initialcity = -1;\n");
                    script.Append("var initialcounty = -1;\n");
                    script.Append("var initialproptype = -1;\n");
                    script.Append("var initialpropstring = \"null\";\n");
                }
            }
            else
            {
                script.Append("var initialregion = -1;\n");
                script.Append("var initialcountry = -1;\n");
                script.Append("var initialstateprovince = -1;\n");
                script.Append("var initialcity = -1;\n");
                script.Append("var initialcounty = -1;\n");
                script.Append("var initialproptype = -1;\n");
                script.Append("var initialpropstring = \"null\";\n");
            }
        }
        else
        {
            script.Append("var initialregion = -1;\n");
            script.Append("var initialcountry = -1;\n");
            script.Append("var initialstateprovince = -1;\n");
            script.Append("var initialcity = -1;\n");
            script.Append("var initialcounty = -1;\n");
            script.Append("var initialproptype = -1;\n");
            script.Append("var initialpropstring = \"null\";\n");
        }

        return script.ToString();
    }

    private void ProcessFurnitureList(CheckBoxList list, int roomid)
    {
        FurnitureSet.Clear();
        FurnitureAdapter.SelectCommand.Parameters["@RoomID"].Value = roomid;
        //lock (CommonFunctions.Connection)
        FurnitureAdapter.Fill(FurnitureSet);

        foreach (ListItem item in list.Items)
        {
            item.Selected = false;
            foreach (DataRow datarow in FurnitureSet.Tables["RoomFurnitureItems"].Rows)
                if ((int)datarow["FurnitureItemID"] == Convert.ToInt32(item.Value))
                {
                    item.Selected = true;
                    break;
                }
        }
    }

    public int GetSelectedIndex(int id)
    {
        int index = 0;

        foreach (DataRow datarow in DistancesSet.Tables["Distances"].Rows)
        {
            if ((int)datarow["ID"] == id)
                return index;
            index++;
        }

        return -1;
    }

    public bool IfEvenRow(System.Data.DataRowView rowview)
    {
        int i = 0;
        foreach (DataRowView curview in rowview.DataView)
        {
            if ((int)rowview.Row["ID"] == (int)curview.Row["ID"])
                break;
            i++;
        }

        return (i % 2) != 0;
    }

    #region Web Form Designer generated code
    override protected void OnInit(EventArgs e)
    {
        //
        // CODEGEN: This call is required by the ASP.NET Web Form Designer.
        //
        InitializeComponent();
        base.OnInit(e);
    }

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        //CommonFunctions.Connection = new System.Data.SqlClient.SqlConnection();
        this.PropertiesSet = new Vacations.PropertiesDataset();
        this.PropertiesAdapter = new System.Data.SqlClient.SqlDataAdapter();
        this.PropertyTypesAdapter = new System.Data.SqlClient.SqlDataAdapter();
        this.sqlInsertCommand4 = new System.Data.SqlClient.SqlCommand();
        this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
        this.PropertyTypesSet = new Vacations.PropertyTypesDataset();
        this.MinimumNightlyRentalTypesAdapter = new System.Data.SqlClient.SqlDataAdapter();
        this.sqlSelectCommand6 = new System.Data.SqlClient.SqlCommand();
        this.MinimumNightlyRentalTypesSet = new Vacations.MinimumNightlyRentalTypesDataset();
        this.CitiesAdapter = new System.Data.SqlClient.SqlDataAdapter();
        this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
        this.sqlSelectCommand7 = new System.Data.SqlClient.SqlCommand();
        this.StateProvincesAdapter = new System.Data.SqlClient.SqlDataAdapter();
        this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
        this.CountriesAdapter = new System.Data.SqlClient.SqlDataAdapter();
        this.sqlSelectCommand9 = new System.Data.SqlClient.SqlCommand();
        this.CountriesSet = new Vacations.CountriesDataset();
        this.GetAdministrators = new System.Data.SqlClient.SqlDataAdapter();
        this.sqlSelectCommand10 = new System.Data.SqlClient.SqlCommand();
        this.UserSet = new Vacations.UserDataset();
        this.RegionsAdapter = new System.Data.SqlClient.SqlDataAdapter();
        this.sqlSelectCommand11 = new System.Data.SqlClient.SqlCommand();
        this.RegionsSet = new Vacations.RegionsDataset();
        this.StateProvincesSet = new Vacations.StateProvincesDataset();
        this.CitiesSet = new Vacations.CitiesDataset();
        this.GetLocationInfo = new System.Data.SqlClient.SqlDataAdapter();
        this.sqlSelectCommand8 = new System.Data.SqlClient.SqlCommand();
        this.FullLocationSet = new Vacations.FullLocationDataset();
        this.AttractionsAdapter = new System.Data.SqlClient.SqlDataAdapter();
        this.sqlSelectCommand12 = new System.Data.SqlClient.SqlCommand();
        this.AttractionsSet = new Vacations.AttractionsDataset();
        this.AmenitiesAdapter = new System.Data.SqlClient.SqlDataAdapter();
        this.sqlSelectCommand13 = new System.Data.SqlClient.SqlCommand();
        this.AmenitiesSet = new Vacations.AmenitiesDataset();
        this.PropertiesAmenitiesAdapter = new System.Data.SqlClient.SqlDataAdapter();
        this.sqlInsertCommand5 = new System.Data.SqlClient.SqlCommand();
        this.sqlSelectCommand4 = new System.Data.SqlClient.SqlCommand();
        this.PropertiesAttractionsAdapter = new System.Data.SqlClient.SqlDataAdapter();
        this.sqlSelectCommand5 = new System.Data.SqlClient.SqlCommand();
        this.PropertiesAttractionsSet = new Vacations.PropertiesAttractionsDataset();
        this.PropertiesAmenitiesSet = new Vacations.PropertiesAmenitiesDataset();
        this.FurnitureItemsAdapter = new System.Data.SqlClient.SqlDataAdapter();
        this.sqlSelectCommand14 = new System.Data.SqlClient.SqlCommand();
        this.FurnitureItemsSet = new Vacations.FurnitureItemsDataset();
        this.DistancesAdapter = new System.Data.SqlClient.SqlDataAdapter();
        this.sqlSelectCommand15 = new System.Data.SqlClient.SqlCommand();
        this.DistancesSet = new Vacations.DistancesDataset();
        this.RoomsAdapter = new System.Data.SqlClient.SqlDataAdapter();
        this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
        this.PaymentMethodsAdapter = new System.Data.SqlClient.SqlDataAdapter();
        this.sqlSelectCommand17 = new System.Data.SqlClient.SqlCommand();
        this.RatesSet = new Vacations.RatesDataset();
        this.RatesAdapter = new System.Data.SqlClient.SqlDataAdapter();
        this.sqlSelectCommand20 = new System.Data.SqlClient.SqlCommand();
        this.FurnitureAdapter = new System.Data.SqlClient.SqlDataAdapter();
        this.sqlSelectCommand16 = new System.Data.SqlClient.SqlCommand();
        this.PaymentMethodsSet = new Vacations.PaymentMethodsDataset();
        this.RoomsSet = new Vacations.RoomsDataset();
        this.FurnitureSet = new Vacations.FurnitureDataset();
        this.PropertiesPaymentMethodsAdapter = new System.Data.SqlClient.SqlDataAdapter();
        this.sqlSelectCommand18 = new System.Data.SqlClient.SqlCommand();
        this.PropertiesPaymentMethodsSet = new Vacations.PropertiesPaymentMethodsDataset();
        this.AttractionsDistancesAdapter = new System.Data.SqlClient.SqlDataAdapter();
        this.sqlCommand2 = new System.Data.SqlClient.SqlCommand();
        this.AttractionsDistancesSet1 = new Vacations.AttractionsDistancesDataset();
        this.RoomFurnitureItemsAdapter = new System.Data.SqlClient.SqlDataAdapter();
        this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
        this.sqlSelectCommand19 = new System.Data.SqlClient.SqlCommand();
        this.RoomFurnitureItemsSet = new Vacations.RoomFurnitureItemsDataset();
        this.AttractionsDistancesSet2 = new Vacations.AttractionsDistancesDataset();
        this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
        ((System.ComponentModel.ISupportInitialize)(this.PropertiesSet)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.PropertyTypesSet)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.MinimumNightlyRentalTypesSet)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.CountriesSet)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.UserSet)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.RegionsSet)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.StateProvincesSet)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.CitiesSet)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.FullLocationSet)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.AttractionsSet)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.AmenitiesSet)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.PropertiesAttractionsSet)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.PropertiesAmenitiesSet)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.FurnitureItemsSet)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.DistancesSet)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.RatesSet)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.PaymentMethodsSet)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.RoomsSet)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.FurnitureSet)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.PropertiesPaymentMethodsSet)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.AttractionsDistancesSet1)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.RoomFurnitureItemsSet)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.AttractionsDistancesSet2)).BeginInit();
        // 
        // CommonFunctions.Connection
        // 
        //CommonFunctions.Connection.ConnectionString = "workstation id=MAIN;packet size=4096;integrated security=SSPI;data source=MAIN;pe" +
        //"rsist security info=False;initial catalog=Vacations";
        // 
        // PropertiesSet
        // 
        this.PropertiesSet.DataSetName = "PropertiesDataset";
        this.PropertiesSet.Locale = new System.Globalization.CultureInfo("en-US");
        // 
        // PropertiesAdapter
        // 
        this.PropertiesAdapter.SelectCommand = this.sqlSelectCommand1;
        this.PropertiesAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Properties", new System.Data.Common.DataColumnMapping[] {
                    new System.Data.Common.DataColumnMapping("ID", "ID"),
                    new System.Data.Common.DataColumnMapping("UserID", "UserID"),
                    new System.Data.Common.DataColumnMapping("Name", "Name"),
                    new System.Data.Common.DataColumnMapping("TypeID", "TypeID"),
                    new System.Data.Common.DataColumnMapping("Address", "Address"),
                    new System.Data.Common.DataColumnMapping("IfShowAddress", "IfShowAddress"),
                    new System.Data.Common.DataColumnMapping("NumBedrooms", "NumBedrooms"),
                    new System.Data.Common.DataColumnMapping("NumBaths", "NumBaths"),
                    new System.Data.Common.DataColumnMapping("NumSleeps", "NumSleeps"),
                    new System.Data.Common.DataColumnMapping("MinimumNightlyRentalID", "MinimumNightlyRentalID"),
                    new System.Data.Common.DataColumnMapping("NumTVs", "NumTVs"),
                    new System.Data.Common.DataColumnMapping("NumVCRs", "NumVCRs"),
                    new System.Data.Common.DataColumnMapping("NumCDPlayers", "NumCDPlayers"),
                    new System.Data.Common.DataColumnMapping("Description", "Description"),
                    new System.Data.Common.DataColumnMapping("Amenities", "Amenities"),
                    new System.Data.Common.DataColumnMapping("LocalAttractions", "LocalAttractions"),
                    new System.Data.Common.DataColumnMapping("Rates", "Rates"),
                    new System.Data.Common.DataColumnMapping("CancellationPolicy", "CancellationPolicy"),
                    new System.Data.Common.DataColumnMapping("DepositRequired", "DepositRequired"),
                    new System.Data.Common.DataColumnMapping("IfMoreThan7PhotosAllowed", "IfMoreThan7PhotosAllowed"),
                    new System.Data.Common.DataColumnMapping("IfApproved", "IfApproved"),
                    new System.Data.Common.DataColumnMapping("CityID", "CityID"),
                    new System.Data.Common.DataColumnMapping("IfFinished", "IfFinished"),
                    new System.Data.Common.DataColumnMapping("DateAdded", "DateAdded"),
                    new System.Data.Common.DataColumnMapping("DateStartViewed", "DateStartViewed"),
                    new System.Data.Common.DataColumnMapping("VirtualTour", "VirtualTour"),
                    new System.Data.Common.DataColumnMapping("RatesTable", "RatesTable"),
                    new System.Data.Common.DataColumnMapping("PricesCurrency", "PricesCurrency"),
                    new System.Data.Common.DataColumnMapping("CheckIn", "CheckIn"),
                    new System.Data.Common.DataColumnMapping("Name2", "Name2"),
                    new System.Data.Common.DataColumnMapping("HiNightRate", "HiNightRate"),
                    new System.Data.Common.DataColumnMapping("MinNightRate", "MinNightRate"),
                    new System.Data.Common.DataColumnMapping("MinRateCurrency", "MinRateCurrency"),
                    new System.Data.Common.DataColumnMapping("CheckOut", "CheckOut"),
                    new System.Data.Common.DataColumnMapping("LodgingTax", "LodgingTax"),
                    new System.Data.Common.DataColumnMapping("TaxIncluded", "TaxIncluded"),
                    new System.Data.Common.DataColumnMapping("DateAvailable", "DateAvailable"),
                    new System.Data.Common.DataColumnMapping("IfDiscounted", "IfDiscounted"),
                    new System.Data.Common.DataColumnMapping("IfLastMinuteCancellations", "IfLastMinuteCancellations"),
                    new System.Data.Common.DataColumnMapping("LastMinuteComments", "LastMinuteComments"),
                    new System.Data.Common.DataColumnMapping("HomeExchangeCityID1", "HomeExchangeCityID1"),
                    new System.Data.Common.DataColumnMapping("HomeExchangeCityID2", "HomeExchangeCityID2"),
                    new System.Data.Common.DataColumnMapping("HomeExchangeCityID3", "HomeExchangeCityID3")})});

        // 
        // PropertyTypesAdapter
        // 
        this.PropertyTypesAdapter.InsertCommand = this.sqlInsertCommand4;
        this.PropertyTypesAdapter.SelectCommand = this.sqlSelectCommand3;
        this.PropertyTypesAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
                                                                                                       new System.Data.Common.DataTableMapping("Table", "PropertyTypes", new System.Data.Common.DataColumnMapping[] {
                                                                                                                                                                                                                        new System.Data.Common.DataColumnMapping("ID", "ID"),
                                                                                                                                                                                                                        new System.Data.Common.DataColumnMapping("Name", "Name")})});
        // 
        // sqlInsertCommand4
        // 
        this.sqlInsertCommand4.CommandText = "INSERT INTO PropertyTypes(ID, Name, Category) VALUES (@ID, @Name, @Category)";
        this.sqlInsertCommand4.Connection = CommonFunctions.GetConnection();
        this.sqlInsertCommand4.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.Int, 4, "ID"));
        this.sqlInsertCommand4.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Name", System.Data.SqlDbType.NVarChar, 300, "Name"));
        this.sqlInsertCommand4.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Category", System.Data.SqlDbType.Int, 4, "Category"));
        // 
        // sqlSelectCommand3
        // 
        this.sqlSelectCommand3.CommandText = "SELECT ID, Name, Case When category is Null Then -1 Else category End category FROM PropertyTypes ORDER " +
"BY Name";
        this.sqlSelectCommand3.Connection = CommonFunctions.GetConnection();
        // 
        // PropertyTypesSet
        // 
        this.PropertyTypesSet.DataSetName = "PropertyTypesDataset";
        this.PropertyTypesSet.Locale = new System.Globalization.CultureInfo("en-US");
        // 
        // MinimumNightlyRentalTypesAdapter
        // 
        this.MinimumNightlyRentalTypesAdapter.SelectCommand = this.sqlSelectCommand6;
        this.MinimumNightlyRentalTypesAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
                                                                                                                   new System.Data.Common.DataTableMapping("Table", "MinimumNightlyRentalTypes", new System.Data.Common.DataColumnMapping[] {
                                                                                                                                                                                                                                                new System.Data.Common.DataColumnMapping("ID", "ID"),
                                                                                                                                                                                                                                                new System.Data.Common.DataColumnMapping("Name", "Name")})});
        // 
        // sqlSelectCommand6
        // 
        this.sqlSelectCommand6.CommandText = "SELECT ID, Name FROM MinimumNightlyRentalTypes";
        this.sqlSelectCommand6.Connection = CommonFunctions.GetConnection();
        // 
        // MinimumNightlyRentalTypesSet
        // 
        this.MinimumNightlyRentalTypesSet.DataSetName = "MinimumNightlyRentalTypesDataset";
        this.MinimumNightlyRentalTypesSet.Locale = new System.Globalization.CultureInfo("en-US");
        // 
        // CitiesAdapter
        // 
        this.CitiesAdapter.InsertCommand = this.sqlInsertCommand1;
        this.CitiesAdapter.SelectCommand = this.sqlSelectCommand7;
        this.CitiesAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
                                                                                                new System.Data.Common.DataTableMapping("Table", "Cities", new System.Data.Common.DataColumnMapping[] {
                                                                                                                                                                                                          new System.Data.Common.DataColumnMapping("ID", "ID"),
                                                                                                                                                                                                          new System.Data.Common.DataColumnMapping("StateProvinceID", "StateProvinceID"),
                                                                                                                                                                                                          new System.Data.Common.DataColumnMapping("City", "City")})});
        // 
        // sqlInsertCommand1
        // 
        this.sqlInsertCommand1.CommandText = "INSERT INTO Cities(StateProvinceID, City) VALUES (@StateProvinceID, @City); SET @ID = SCOPE_IDENTITY();";
        this.sqlInsertCommand1.Connection = CommonFunctions.GetConnection();
        this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@StateProvinceID", System.Data.SqlDbType.Int, 4, "StateProvinceID"));
        this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@City", System.Data.SqlDbType.NVarChar, 300, "City"));
        this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "ID", DataRowVersion.Current, 0));
        // 
        // sqlSelectCommand7
        // 
        this.sqlSelectCommand7.CommandText = "SELECT ID, StateProvinceID, City FROM Cities ORDER BY City";
        this.sqlSelectCommand7.Connection = CommonFunctions.GetConnection();
        // 
        // StateProvincesAdapter
        // 
        this.StateProvincesAdapter.SelectCommand = this.sqlSelectCommand2;
        this.StateProvincesAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
                                                                                                        new System.Data.Common.DataTableMapping("Table", "StateProvinces", new System.Data.Common.DataColumnMapping[] {
                                                                                                                                                                                                                          new System.Data.Common.DataColumnMapping("ID", "ID"),
                                                                                                                                                                                                                          new System.Data.Common.DataColumnMapping("CountryID", "CountryID"),
                                                                                                                                                                                                                          new System.Data.Common.DataColumnMapping("StateProvince", "StateProvince")})});
        // 
        // sqlSelectCommand2
        // 
        this.sqlSelectCommand2.CommandText = "SELECT ID, CountryID, StateProvince FROM StateProvinces ORDER BY StateProvince";
        this.sqlSelectCommand2.Connection = CommonFunctions.GetConnection();
        // 
        // CountriesAdapter
        // 
        this.CountriesAdapter.SelectCommand = this.sqlSelectCommand9;
        this.CountriesAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
                                                                                                   new System.Data.Common.DataTableMapping("Table", "Countries", new System.Data.Common.DataColumnMapping[] {
                                                                                                                                                                                                                new System.Data.Common.DataColumnMapping("ID", "ID"),
                                                                                                                                                                                                                new System.Data.Common.DataColumnMapping("RegionID", "RegionID"),
                                                                                                                                                                                                                new System.Data.Common.DataColumnMapping("Country", "Country")})});
        // 
        // sqlSelectCommand9
        // 
        this.sqlSelectCommand9.CommandText = "SELECT ID, RegionID, Country FROM Countries ORDER BY" +
            " Country";
        this.sqlSelectCommand9.Connection = CommonFunctions.GetConnection();
        // 
        // CountriesSet
        // 
        this.CountriesSet.DataSetName = "CountriesDataset";
        this.CountriesSet.Locale = new System.Globalization.CultureInfo("en-US");
        // 
        // GetAdministrators
        // 
        this.GetAdministrators.SelectCommand = this.sqlSelectCommand10;
        this.GetAdministrators.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
                                                                                                    new System.Data.Common.DataTableMapping("Table", "Users", new System.Data.Common.DataColumnMapping[] {
                                                                                                                                                                                                             new System.Data.Common.DataColumnMapping("ID", "ID"),
                                                                                                                                                                                                             new System.Data.Common.DataColumnMapping("Username", "Username"),
                                                                                                                                                                                                             new System.Data.Common.DataColumnMapping("PasswordSalt", "PasswordSalt"),
                                                                                                                                                                                                             new System.Data.Common.DataColumnMapping("Repeats", "Repeats"),
                                                                                                                                                                                                             new System.Data.Common.DataColumnMapping("PasswordHash", "PasswordHash"),
                                                                                                                                                                                                             new System.Data.Common.DataColumnMapping("Email", "Email"),
                                                                                                                                                                                                             new System.Data.Common.DataColumnMapping("FirstName", "FirstName"),
                                                                                                                                                                                                             new System.Data.Common.DataColumnMapping("LastName", "LastName"),
                                                                                                                                                                                                             new System.Data.Common.DataColumnMapping("Address", "Address"),
                                                                                                                                                                                                             new System.Data.Common.DataColumnMapping("City", "City"),
                                                                                                                                                                                                             new System.Data.Common.DataColumnMapping("State", "State"),
                                                                                                                                                                                                             new System.Data.Common.DataColumnMapping("Zip", "Zip"),
                                                                                                                                                                                                             new System.Data.Common.DataColumnMapping("Country", "Country"),
                                                                                                                                                                                                             new System.Data.Common.DataColumnMapping("PrimaryTelephone", "PrimaryTelephone"),
                                                                                                                                                                                                             new System.Data.Common.DataColumnMapping("EveningTelephone", "EveningTelephone"),
                                                                                                                                                                                                             new System.Data.Common.DataColumnMapping("DaytimeTelephone", "DaytimeTelephone"),
                                                                                                                                                                                                             new System.Data.Common.DataColumnMapping("MobileTelephone", "MobileTelephone"),
                                                                                                                                                                                                             new System.Data.Common.DataColumnMapping("Website", "Website"),
                                                                                                                                                                                                             new System.Data.Common.DataColumnMapping("IfAdmin", "IfAdmin"),
                                                                                                                                                                                                             new System.Data.Common.DataColumnMapping("CompanyName", "CompanyName"),
                                                                                                                                                                                                             new System.Data.Common.DataColumnMapping("Registered", "Registered"),
                                                                                                                                                                                                             new System.Data.Common.DataColumnMapping("IfPayTravelAgents", "IfPayTravelAgents")})});
        // 
        // sqlSelectCommand10
        // 
        this.sqlSelectCommand10.CommandText = @"SELECT ID, Username, PasswordSalt, Repeats, PasswordHash, Email, FirstName, LastName, Address, City, State, Zip, Country, PrimaryTelephone, EveningTelephone, DaytimeTelephone, MobileTelephone, Website, IfAdmin, CompanyName, Registered, IfPayTravelAgents FROM Users WHERE (IfAdmin = 1)";
        this.sqlSelectCommand10.Connection = CommonFunctions.GetConnection();
        // 
        // UserSet
        // 
        this.UserSet.DataSetName = "UserDataset";
        this.UserSet.Locale = new System.Globalization.CultureInfo("en-US");
        // 
        // RegionsAdapter
        // 
        this.RegionsAdapter.SelectCommand = this.sqlSelectCommand11;
        this.RegionsAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
                                                                                                 new System.Data.Common.DataTableMapping("Table", "Regions", new System.Data.Common.DataColumnMapping[] {
                                                                                                                                                                                                            new System.Data.Common.DataColumnMapping("ID", "ID"),
                                                                                                                                                                                                            new System.Data.Common.DataColumnMapping("Region", "Region")})});
        // 
        // sqlSelectCommand11
        // 
        this.sqlSelectCommand11.CommandText = "SELECT ID, Region FROM Regions ORDER BY Region";
        this.sqlSelectCommand11.Connection = CommonFunctions.GetConnection();
        // 
        // RegionsSet
        // 
        this.RegionsSet.DataSetName = "RegionsDataset";
        this.RegionsSet.Locale = new System.Globalization.CultureInfo("en-US");
        // 
        // StateProvincesSet
        // 
        this.StateProvincesSet.DataSetName = "StateProvincesDataset";
        this.StateProvincesSet.Locale = new System.Globalization.CultureInfo("en-US");
        // 
        // CitiesSet
        // 
        this.CitiesSet.DataSetName = "CitiesDataset";
        this.CitiesSet.Locale = new System.Globalization.CultureInfo("en-US");
        // 
        // GetLocationInfo
        // 
        this.GetLocationInfo.SelectCommand = this.sqlSelectCommand8;
        this.GetLocationInfo.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
                                                                                                  new System.Data.Common.DataTableMapping("Table", "Cities", new System.Data.Common.DataColumnMapping[] {
                                                                                                                                                                                                            new System.Data.Common.DataColumnMapping("CityID", "CityID"),
                                                                                                                                                                                                            new System.Data.Common.DataColumnMapping("City", "City"),
                                                                                                                                                                                                            new System.Data.Common.DataColumnMapping("StateProvinceID", "StateProvinceID"),
                                                                                                                                                                                                            new System.Data.Common.DataColumnMapping("StateProvince", "StateProvince"),
                                                                                                                                                                                                            new System.Data.Common.DataColumnMapping("CountryID", "CountryID"),
                                                                                                                                                                                                            new System.Data.Common.DataColumnMapping("Country", "Country"),
                                                                                                                                                                                                            new System.Data.Common.DataColumnMapping("RegionID", "RegionID"),
                                                                                                                                                                                                            new System.Data.Common.DataColumnMapping("Region", "Region")})});
        // 
        // sqlSelectCommand8
        // 
        this.sqlSelectCommand8.CommandText = @"SELECT Cities.ID AS CityID, Cities.City, StateProvinces.ID AS StateProvinceID, StateProvinces.StateProvince, Countries.ID AS CountryID, Countries.Country, Regions.ID AS RegionID, Regions.Region FROM Cities INNER JOIN StateProvinces ON StateProvinces.ID = Cities.StateProvinceID INNER JOIN Countries ON StateProvinces.CountryID = Countries.ID INNER JOIN Regions ON Countries.RegionID = Regions.ID WHERE (Cities.ID = @CityID)";
        this.sqlSelectCommand8.Connection = CommonFunctions.GetConnection();
        this.sqlSelectCommand8.Parameters.Add(new System.Data.SqlClient.SqlParameter("@CityID", System.Data.SqlDbType.Int, 4, "CityID"));
        // 
        // FullLocationSet
        // 
        this.FullLocationSet.DataSetName = "FullLocationDataset";
        this.FullLocationSet.Locale = new System.Globalization.CultureInfo("en-US");
        // 
        // AttractionsAdapter
        // 
        this.AttractionsAdapter.SelectCommand = this.sqlSelectCommand12;
        this.AttractionsAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
                                                                                                     new System.Data.Common.DataTableMapping("Table", "Attractions", new System.Data.Common.DataColumnMapping[] {
                                                                                                                                                                                                                    new System.Data.Common.DataColumnMapping("ID", "ID"),
                                                                                                                                                                                                                    new System.Data.Common.DataColumnMapping("Attraction", "Attraction")})});
        // 
        // sqlSelectCommand12
        // 
        this.sqlSelectCommand12.CommandText = "SELECT ID, Attraction FROM Attractions";
        this.sqlSelectCommand12.Connection = CommonFunctions.GetConnection();
        // 
        // AttractionsSet
        // 
        this.AttractionsSet.DataSetName = "AttractionsDataset";
        this.AttractionsSet.Locale = new System.Globalization.CultureInfo("en-US");
        // 
        // AmenitiesAdapter
        // 
        this.AmenitiesAdapter.SelectCommand = this.sqlSelectCommand13;
        this.AmenitiesAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
                                                                                                   new System.Data.Common.DataTableMapping("Table", "Amenities", new System.Data.Common.DataColumnMapping[] {
                                                                                                                                                                                                                new System.Data.Common.DataColumnMapping("ID", "ID"),
                                                                                                                                                                                                                new System.Data.Common.DataColumnMapping("Amenity", "Amenity")})});
        // 
        // sqlSelectCommand13
        // 
        this.sqlSelectCommand13.CommandText = "SELECT ID, Amenity FROM Amenities";
        this.sqlSelectCommand13.Connection = CommonFunctions.GetConnection();
        // 
        // AmenitiesSet
        // 
        this.AmenitiesSet.DataSetName = "AmenitiesDataset";
        this.AmenitiesSet.Locale = new System.Globalization.CultureInfo("en-US");
        // 
        // PropertiesAmenitiesAdapter
        // 
        this.PropertiesAmenitiesAdapter.InsertCommand = this.sqlInsertCommand5;
        this.PropertiesAmenitiesAdapter.SelectCommand = this.sqlSelectCommand4;
        this.PropertiesAmenitiesAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
                                                                                                             new System.Data.Common.DataTableMapping("Table", "PropertiesAmenities", new System.Data.Common.DataColumnMapping[] {
                                                                                                                                                                                                                                    new System.Data.Common.DataColumnMapping("ID", "ID"),
                                                                                                                                                                                                                                    new System.Data.Common.DataColumnMapping("PropertyID", "PropertyID"),
                                                                                                                                                                                                                                    new System.Data.Common.DataColumnMapping("AmenityID", "AmenityID")})});
        // 
        // sqlInsertCommand5
        // 
        this.sqlInsertCommand5.CommandText = "INSERT INTO PropertiesAmenities(PropertyID, AmenityID) VALUES (@PropertyID, @Amen" +
            "ityID)";
        this.sqlInsertCommand5.Connection = CommonFunctions.GetConnection();
        this.sqlInsertCommand5.Parameters.Add(new System.Data.SqlClient.SqlParameter("@PropertyID", System.Data.SqlDbType.Int, 4, "PropertyID"));
        this.sqlInsertCommand5.Parameters.Add(new System.Data.SqlClient.SqlParameter("@AmenityID", System.Data.SqlDbType.Int, 4, "AmenityID"));
        // 
        // sqlSelectCommand4
        // 
        this.sqlSelectCommand4.CommandText = "SELECT ID, PropertyID, AmenityID FROM PropertiesAmenities WHERE (PropertyID = @Pr" +
            "opertyID)";
        this.sqlSelectCommand4.Connection = CommonFunctions.GetConnection();
        this.sqlSelectCommand4.Parameters.Add(new System.Data.SqlClient.SqlParameter("@PropertyID", System.Data.SqlDbType.Int, 4, "PropertyID"));
        // 
        // PropertiesAttractionsAdapter
        // 
        this.PropertiesAttractionsAdapter.SelectCommand = this.sqlSelectCommand5;
        this.PropertiesAttractionsAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
                                                                                                               new System.Data.Common.DataTableMapping("Table", "PropertiesAttractions", new System.Data.Common.DataColumnMapping[] {
                                                                                                                                                                                                                                        new System.Data.Common.DataColumnMapping("ID", "ID"),
                                                                                                                                                                                                                                        new System.Data.Common.DataColumnMapping("PropertyID", "PropertyID"),
                                                                                                                                                                                                                                        new System.Data.Common.DataColumnMapping("AttractionID", "AttractionID"),
                                                                                                                                                                                                                                        new System.Data.Common.DataColumnMapping("DistanceID", "DistanceID")})});
        // 
        // sqlSelectCommand5
        // 
        this.sqlSelectCommand5.CommandText = "SELECT ID, PropertyID, AttractionID, DistanceID FROM PropertiesAttractions WHERE " +
            "(PropertyID = @PropertyID)";
        this.sqlSelectCommand5.Connection = CommonFunctions.GetConnection();
        this.sqlSelectCommand5.Parameters.Add(new System.Data.SqlClient.SqlParameter("@PropertyID", System.Data.SqlDbType.Int, 4, "PropertyID"));
        // 
        // PropertiesAttractionsSet
        // 
        this.PropertiesAttractionsSet.DataSetName = "PropertiesAttractionsDataset";
        this.PropertiesAttractionsSet.Locale = new System.Globalization.CultureInfo("en-US");
        // 
        // PropertiesAmenitiesSet
        // 
        this.PropertiesAmenitiesSet.DataSetName = "PropertiesAmenitiesDataset";
        this.PropertiesAmenitiesSet.Locale = new System.Globalization.CultureInfo("en-US");
        // 
        // FurnitureItemsAdapter
        // 
        this.FurnitureItemsAdapter.SelectCommand = this.sqlSelectCommand14;
        this.FurnitureItemsAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
                                                                                                        new System.Data.Common.DataTableMapping("Table", "FurnitureItems", new System.Data.Common.DataColumnMapping[] {
                                                                                                                                                                                                                          new System.Data.Common.DataColumnMapping("ID", "ID"),
                                                                                                                                                                                                                          new System.Data.Common.DataColumnMapping("FurnitureItem", "FurnitureItem")})});
        // 
        // sqlSelectCommand14
        // 
        this.sqlSelectCommand14.CommandText = "SELECT ID, FurnitureItem FROM FurnitureItems";
        this.sqlSelectCommand14.Connection = CommonFunctions.GetConnection();
        // 
        // FurnitureItemsSet
        // 
        this.FurnitureItemsSet.DataSetName = "FurnitureItemsDataset";
        this.FurnitureItemsSet.Locale = new System.Globalization.CultureInfo("en-US");
        // 
        // DistancesAdapter
        // 
        this.DistancesAdapter.SelectCommand = this.sqlSelectCommand15;
        this.DistancesAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
                                                                                                   new System.Data.Common.DataTableMapping("Table", "Distances", new System.Data.Common.DataColumnMapping[] {
                                                                                                                                                                                                                new System.Data.Common.DataColumnMapping("ID", "ID"),
                                                                                                                                                                                                                new System.Data.Common.DataColumnMapping("Distance", "Distance")})});
        // 
        // sqlSelectCommand15
        // 
        this.sqlSelectCommand15.CommandText = "SELECT ID, Distance FROM Distances";
        this.sqlSelectCommand15.Connection = CommonFunctions.GetConnection();
        // 
        // DistancesSet
        // 
        this.DistancesSet.DataSetName = "DistancesDataset";
        this.DistancesSet.Locale = new System.Globalization.CultureInfo("en-US");
        // 
        // RoomsAdapter
        // 
        this.RoomsAdapter.SelectCommand = this.sqlCommand1;
        this.RoomsAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
                                                                                               new System.Data.Common.DataTableMapping("Table", "RoomInfo", new System.Data.Common.DataColumnMapping[] {
                                                                                                                                                                                                           new System.Data.Common.DataColumnMapping("ID", "ID"),
                                                                                                                                                                                                           new System.Data.Common.DataColumnMapping("PropertyID", "PropertyID"),
                                                                                                                                                                                                           new System.Data.Common.DataColumnMapping("RoomTitle", "RoomTitle")})});
        // 
        // sqlCommand1
        // 
        this.sqlCommand1.CommandText = "SELECT ID, PropertyID, RoomTitle FROM RoomInfo WHERE (PropertyID = @PropertyID)";
        this.sqlCommand1.Connection = CommonFunctions.GetConnection();
        this.sqlCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@PropertyID", System.Data.SqlDbType.Int, 4, "PropertyID"));
        // 
        // PaymentMethodsAdapter
        // 
        this.PaymentMethodsAdapter.SelectCommand = this.sqlSelectCommand17;
        this.PaymentMethodsAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
                                                                                                        new System.Data.Common.DataTableMapping("Table", "PaymentMethods", new System.Data.Common.DataColumnMapping[] {
                                                                                                                                                                                                                          new System.Data.Common.DataColumnMapping("ID", "ID"),
                                                                                                                                                                                                                          new System.Data.Common.DataColumnMapping("PaymentMethod", "PaymentMethod")})});
        // 
        // sqlSelectCommand17
        // 
        this.sqlSelectCommand17.CommandText = "SELECT ID, PaymentMethod FROM PaymentMethods";
        this.sqlSelectCommand17.Connection = CommonFunctions.GetConnection();
        // 
        // RatesSet
        // 
        this.RatesSet.DataSetName = "RatesDataset";
        this.RatesSet.Locale = new System.Globalization.CultureInfo("en-US");
        // 
        // RatesAdapter
        // 
        this.RatesAdapter.SelectCommand = this.sqlSelectCommand20;
        this.RatesAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
                                                                                               new System.Data.Common.DataTableMapping("Table", "Rates", new System.Data.Common.DataColumnMapping[] {
                                                                                                                                                                                                        new System.Data.Common.DataColumnMapping("ID", "ID"),
                                                                                                                                                                                                        new System.Data.Common.DataColumnMapping("PropertyID", "PropertyID"),
                                                                                                                                                                                                        new System.Data.Common.DataColumnMapping("StartDate", "StartDate"),
                                                                                                                                                                                                        new System.Data.Common.DataColumnMapping("EndDate", "EndDate"),
                                                                                                                                                                                                        new System.Data.Common.DataColumnMapping("Nightly", "Nightly"),
                                                                                                                                                                                                        new System.Data.Common.DataColumnMapping("Weekly", "Weekly"),
                                                                                                                                                                                                        new System.Data.Common.DataColumnMapping("Monthly", "Monthly")})});
        // 
        // sqlSelectCommand20
        // 
        this.sqlSelectCommand20.CommandText = "SELECT ID, PropertyID, StartDate, EndDate, Nightly, Weekly, Monthly FROM Rates WH" +
            "ERE (PropertyID = @PropertyID)";
        this.sqlSelectCommand20.Connection = CommonFunctions.GetConnection();
        this.sqlSelectCommand20.Parameters.Add(new System.Data.SqlClient.SqlParameter("@PropertyID", System.Data.SqlDbType.Int, 4, "PropertyID"));
        // 
        // FurnitureAdapter
        // 
        this.FurnitureAdapter.SelectCommand = this.sqlSelectCommand16;
        this.FurnitureAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
                                                                                                   new System.Data.Common.DataTableMapping("Table", "RoomFurnitureItems", new System.Data.Common.DataColumnMapping[] {
                                                                                                                                                                                                                         new System.Data.Common.DataColumnMapping("ID", "ID"),
                                                                                                                                                                                                                         new System.Data.Common.DataColumnMapping("RoomID", "RoomID"),
                                                                                                                                                                                                                         new System.Data.Common.DataColumnMapping("FurnitureItemID", "FurnitureItemID")})});
        // 
        // sqlSelectCommand16
        // 
        this.sqlSelectCommand16.CommandText = "SELECT ID, RoomID, FurnitureItemID FROM RoomFurnitureItems WHERE (RoomID = @RoomI" +
            "D)";
        this.sqlSelectCommand16.Connection = CommonFunctions.GetConnection();
        this.sqlSelectCommand16.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RoomID", System.Data.SqlDbType.Int, 4, "RoomID"));
        // 
        // PaymentMethodsSet
        // 
        this.PaymentMethodsSet.DataSetName = "PaymentMethodsDataset";
        this.PaymentMethodsSet.Locale = new System.Globalization.CultureInfo("en-US");
        // 
        // RoomsSet
        // 
        this.RoomsSet.DataSetName = "RoomsDataset";
        this.RoomsSet.Locale = new System.Globalization.CultureInfo("en-US");
        // 
        // FurnitureSet
        // 
        this.FurnitureSet.DataSetName = "FurnitureDataset";
        this.FurnitureSet.Locale = new System.Globalization.CultureInfo("en-US");
        // 
        // PropertiesPaymentMethodsAdapter
        // 
        this.PropertiesPaymentMethodsAdapter.SelectCommand = this.sqlSelectCommand18;
        this.PropertiesPaymentMethodsAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
                                                                                                                  new System.Data.Common.DataTableMapping("Table", "PropertiesPaymentMethods", new System.Data.Common.DataColumnMapping[] {
                                                                                                                                                                                                                                              new System.Data.Common.DataColumnMapping("ID", "ID"),
                                                                                                                                                                                                                                              new System.Data.Common.DataColumnMapping("PropertyID", "PropertyID"),
                                                                                                                                                                                                                                              new System.Data.Common.DataColumnMapping("PaymentMethodID", "PaymentMethodID")})});
        // 
        // sqlSelectCommand18
        // 
        this.sqlSelectCommand18.CommandText = "SELECT ID, PropertyID, PaymentMethodID FROM PropertiesPaymentMethods WHERE (Prope" +
            "rtyID = @PropertyID)";
        this.sqlSelectCommand18.Connection = CommonFunctions.GetConnection();
        this.sqlSelectCommand18.Parameters.Add(new System.Data.SqlClient.SqlParameter("@PropertyID", System.Data.SqlDbType.Int, 4, "PropertyID"));
        // 
        // PropertiesPaymentMethodsSet
        // 
        this.PropertiesPaymentMethodsSet.DataSetName = "PropertiesPaymentMethodsDataset";
        this.PropertiesPaymentMethodsSet.Locale = new System.Globalization.CultureInfo("en-US");
        // 
        // AttractionsDistancesAdapter
        // 
        this.AttractionsDistancesAdapter.SelectCommand = this.sqlCommand2;
        this.AttractionsDistancesAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
                                                                                                              new System.Data.Common.DataTableMapping("Table", "Attractions", new System.Data.Common.DataColumnMapping[] {
                                                                                                                                                                                                                             new System.Data.Common.DataColumnMapping("ID", "ID"),
                                                                                                                                                                                                                             new System.Data.Common.DataColumnMapping("Attraction", "Attraction"),
                                                                                                                                                                                                                             new System.Data.Common.DataColumnMapping("Distance", "Distance")})});
        // 
        // sqlCommand2
        // 
        this.sqlCommand2.CommandText = @"SELECT Attractions.*, (SELECT Distances.ID FROM PropertiesAttractions INNER JOIN Distances ON PropertiesAttractions.DistanceID = Distances.ID WHERE (PropertiesAttractions.AttractionID = Attractions.ID) AND (PropertiesAttractions.PropertyID = @PropertyID)) AS DistanceID, (SELECT Distances.Distance FROM PropertiesAttractions INNER JOIN Distances ON PropertiesAttractions.DistanceID = Distances.ID WHERE (PropertiesAttractions.AttractionID = Attractions.ID) AND (PropertiesAttractions.PropertyID = @PropertyID)) AS Distance FROM Attractions";
        this.sqlCommand2.Connection = CommonFunctions.GetConnection();
        this.sqlCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@PropertyID", System.Data.SqlDbType.Int, 4, "PropertyID"));
        // 
        // AttractionsDistancesSet1
        // 
        this.AttractionsDistancesSet1.DataSetName = "AttractionsDistancesDataset";
        this.AttractionsDistancesSet1.Locale = new System.Globalization.CultureInfo("en-US");
        // 
        // RoomFurnitureItemsAdapter
        // 
        this.RoomFurnitureItemsAdapter.InsertCommand = this.sqlInsertCommand2;
        this.RoomFurnitureItemsAdapter.SelectCommand = this.sqlSelectCommand19;
        this.RoomFurnitureItemsAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
                                                                                                            new System.Data.Common.DataTableMapping("Table", "RoomFurnitureItems", new System.Data.Common.DataColumnMapping[] {
                                                                                                                                                                                                                                  new System.Data.Common.DataColumnMapping("ID", "ID"),
                                                                                                                                                                                                                                  new System.Data.Common.DataColumnMapping("RoomID", "RoomID"),
                                                                                                                                                                                                                                  new System.Data.Common.DataColumnMapping("FurnitureItemID", "FurnitureItemID")})});
        // 
        // sqlInsertCommand2
        // 
        this.sqlInsertCommand2.CommandText = "INSERT INTO RoomFurnitureItems(RoomID, FurnitureItemID) VALUES (@RoomID, @Furnitu" +
            "reItemID)";
        this.sqlInsertCommand2.Connection = CommonFunctions.GetConnection();
        this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RoomID", System.Data.SqlDbType.Int, 4, "RoomID"));
        this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@FurnitureItemID", System.Data.SqlDbType.Int, 4, "FurnitureItemID"));
        // 
        // sqlSelectCommand19
        // 
        this.sqlSelectCommand19.CommandText = "SELECT ID, RoomID, FurnitureItemID FROM RoomFurnitureItems WHERE EXISTS (SELECT *" +
            " FROM RoomInfo WHERE (RoomInfo.ID = RoomID) AND (RoomInfo.PropertyID = @Property" +
            "ID))";
        this.sqlSelectCommand19.Connection = CommonFunctions.GetConnection();
        this.sqlSelectCommand19.Parameters.Add(new System.Data.SqlClient.SqlParameter("@PropertyID", System.Data.SqlDbType.Int, 4, "PropertyID"));
        // 
        // RoomFurnitureItemsSet
        // 
        this.RoomFurnitureItemsSet.DataSetName = "RoomFurnitureItemsDataset";
        this.RoomFurnitureItemsSet.Locale = new System.Globalization.CultureInfo("en-US");
        // 
        // AttractionsDistancesSet2
        // 
        this.AttractionsDistancesSet2.DataSetName = "AttractionsDistancesDataset";
        this.AttractionsDistancesSet2.Locale = new System.Globalization.CultureInfo("en-US");
        // 
        // sqlSelectCommand1
        // 
        this.sqlSelectCommand1.CommandText = @"SELECT ID, UserID, Name, TypeID, Address, IfShowAddress, NumBedrooms, NumBaths, NumSleeps, MinimumNightlyRentalID, NumTVs, NumVCRs, NumCDPlayers, Description, Amenities, LocalAttractions, Rates, CancellationPolicy, DepositRequired, IfMoreThan7PhotosAllowed, Name2, MinRateCurrency, MinNightRate, HiNightRate, IfApproved, CityID, IfFinished, DateAdded, DateStartViewed, VirtualTour, RatesTable, PricesCurrency, CheckIn, CheckOut, LodgingTax, TaxIncluded, DateAvailable, IfDiscounted, IfLastMinuteCancellations, LastMinuteComments, HomeExchangeCityID1, HomeExchangeCityID2, HomeExchangeCityID3 FROM Properties WHERE (ID = @PropertyID) AND ((IfFinished = 1) OR NOT EXISTS (SELECT * FROM Auctions WHERE PropertyID = Properties.ID))";
        this.sqlSelectCommand1.Connection = CommonFunctions.GetConnection();
        this.sqlSelectCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@PropertyID", System.Data.SqlDbType.Int, 4, "ID"));
        ((System.ComponentModel.ISupportInitialize)(this.PropertiesSet)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.PropertyTypesSet)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.MinimumNightlyRentalTypesSet)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.CountriesSet)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.UserSet)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.RegionsSet)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.StateProvincesSet)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.CitiesSet)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.FullLocationSet)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.AttractionsSet)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.AmenitiesSet)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.PropertiesAttractionsSet)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.PropertiesAmenitiesSet)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.FurnitureItemsSet)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.DistancesSet)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.RatesSet)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.PaymentMethodsSet)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.RoomsSet)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.FurnitureSet)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.PropertiesPaymentMethodsSet)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.AttractionsDistancesSet1)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.RoomFurnitureItemsSet)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.AttractionsDistancesSet2)).EndInit();

    }
    #endregion

    protected void CancelButton_Click(object sender, System.EventArgs e)
    {
        Response.Redirect(backlinkurl);
    }
    private bool EmptyBoxes()
    {
        bool vValue = false;

        return vValue;
    }
    protected void SubmitButton_Click(object sender, System.EventArgs e)
    {
        int newpropertytypeid;

        try
        {
            if (Request.Params["PropertyType"] == "0")
                {
                    object maxid;
                    using (SqlConnection connection = CommonFunctions.GetConnection())
                    {
                        connection.Open();
                        System.Data.SqlClient.SqlCommand getmaxid = new System.Data.SqlClient.SqlCommand(
                            "SELECT MAX(ID) FROM PropertyTypes", connection);

                        maxid = getmaxid.ExecuteScalar();
                        connection.Close();
                    }

                    if (maxid is DBNull)
                        newpropertytypeid = 1;
                    else
                        newpropertytypeid = (int)maxid + 1;

                    System.Data.DataRow newtype = PropertyTypesSet.Tables["PropertyTypes"].NewRow();

                    newtype["ID"] = newpropertytypeid;
                    //newtype["Name"] = CommonFunctions.EncodeInput(PropertyTypeNew.Text);
                    newtype["Name"] = CommonFunctions.EncodeInput(Request.Params["PropertyTypeNew"]);
                    //**link to property main categories here
                    string strCurType = Request.Params["PrimaryType"];

                    newtype["Category"] = strCurType;
                    PropertyTypesSet.Tables["PropertyTypes"].Rows.Add(newtype);

                    //lock (CommonFunctions.Connection)
                    PropertyTypesAdapter.Update(PropertyTypesSet);
                }
                else
                    newpropertytypeid = -1;

                PropertiesSet.Tables["Properties"].Rows[0]["Name"] = CommonFunctions.EncodeInput(PropertyName.Text);
                PropertiesSet.Tables["Properties"].Rows[0]["Name2"] = CommonFunctions.EncodeInput(txtPropName.Text);

                if (newpropertytypeid == -1)
                    PropertiesSet.Tables["Properties"].Rows[0]["TypeID"] = Convert.ToInt32(Request.Params["PropertyType"]);
                else
                    PropertiesSet.Tables["Properties"].Rows[0]["TypeID"] = newpropertytypeid;
                PropertiesSet.Tables["Properties"].Rows[0]["Address"] = CommonFunctions.EncodeInput(AddressLocation.Text);
                PropertiesSet.Tables["Properties"].Rows[0]["IfShowAddress"] = (ShowAddress.Items[ShowAddress.SelectedIndex].Text == "Yes");
                if (Request.Params["City"] == "0")
                {
                    DataRow newcity = CitiesSet.Tables["Cities"].NewRow();

                    newcity["City"] = CommonFunctions.EncodeInput(CityNew.Text);

                    try
                    {
                        newcity["StateProvinceID"] = Convert.ToInt32(Request.Params["state"]);
                    }
                    catch (Exception)
                    {
                        LocationError.Visible = true;
                        return;
                    }

                    CitiesSet.Tables["Cities"].Rows.Add(newcity);

                    //lock (CommonFunctions.Connection)
                    CitiesAdapter.Update(CitiesSet);





                    int vCityID = 0;
                    int vCountyID = 0;
                    string vCounty = "";
                    string query = "";
                    DBConnection obj = new DBConnection();
                    DataTable dt = new DataTable();

                    PropertiesSet.Tables["Properties"].Rows[0]["CityID"] = DBNull.Value;
                    foreach (DataRow datarow in CitiesSet.Tables["Cities"].Rows)
                        if ((string)datarow["City"] == CommonFunctions.EncodeInput(CityNew.Text))
                        {
                            vCityID = (int)datarow["ID"];
                            PropertiesSet.Tables["Properties"].Rows[0]["CityID"] = datarow["ID"];
                            break;
                        }

                    if (PropertiesSet.Tables["Properties"].Rows[0]["CityID"] is DBNull)
                        Response.Redirect(CommonFunctions.PrepareURL("InternalError.aspx"), true);

                    //city already relates to state by id's...need to relate newly added city to county relation selected
                    //by putting cityid, county, and countyid into counties table
                    if (Request.Params["county"] != null)
                        if (Convert.ToInt32(Request.Params["county"]) > 0)
                        {
                            try
                            {
                                vCountyID = Convert.ToInt32(Request.Params["county"]);
                                dt = VADBCommander.CountyNameInd(vCountyID.ToString());

                                if (dt.Rows.Count > 0)
                                {
                                    vCounty = dt.Rows[0]["countyname"].ToString();
                                    VADBCommander.CountyAdd(vCityID.ToString(), vCounty, vCountyID.ToString());
                                }
                            }
                            catch (Exception ex) { lblInfo.Text = ex.Message; }
                            finally { obj.CloseConnection(); }
                        }
                }
                else
                {
                    try
                    {
                        PropertiesSet.Tables["Properties"].Rows[0]["CityID"] = Convert.ToInt32(Request.Params["City"]);
                    }
                    catch (Exception)
                    {
                        LocationError.Visible = true;
                        return;
                    }
                }

                // Add New Code
                int CityLatLong;
                bool IsExitsCity;
                string cityname = string.Empty;
                if (!string.IsNullOrEmpty(CityNew.Text) && CityNew.Text != "undefined")
                {
                    cityname = CityNew.Text;
                }
                else
                {
                    cityname = hdcity.Value.ToString();
                }
                if (!string.IsNullOrEmpty(cityname))
                {
                    using (SqlConnection connection = CommonFunctions.GetConnection())
                    {
                        connection.Open();
                        System.Data.SqlClient.SqlCommand cmdcity = new System.Data.SqlClient.SqlCommand(
                            "SELECT count(City) FROM CityLatLong where City='" + cityname + "'", connection);

                        CityLatLong = Convert.ToInt32(cmdcity.ExecuteScalar());
                        connection.Close();
                        cmdcity.Dispose();
                    }
                    if (CityLatLong == 0)
                        IsExitsCity = true;
                    else
                        IsExitsCity = false;

                    if (IsExitsCity)
                    {

                        if (!string.IsNullOrEmpty(hdnLongitude.Value) && !string.IsNullOrEmpty(hdnLatitude.Value) && !string.IsNullOrEmpty(hdnCountry.Value) && !string.IsNullOrEmpty(hdnState.Value))
                        {
                            using (SqlConnection connection = CommonFunctions.GetConnection())
                            {
                                connection.Open();
                                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(
                                    "Insert into CityLatLong(Country,StateProvince,City,Longitude,Latitude)values('" + hdnCountry.Value.ToString() + "','" + hdnState.Value.ToString() + "','" + cityname + "'," + float.Parse(hdnLongitude.Value) + "," + float.Parse(hdnLatitude.Value) + ")", connection);

                                cmd.ExecuteNonQuery();
                                connection.Close();
                            }

                        }
                    }

                }

                if (VirtualTour.Text.Length > 0)
                {
                    if (!VirtualTour.Text.StartsWith("http://"))
                        VirtualTour.Text = "http://" + CommonFunctions.EncodeInput(VirtualTour.Text);
                    PropertiesSet.Tables["Properties"].Rows[0]["VirtualTour"] = CommonFunctions.EncodeInput(VirtualTour.Text);
                }

                PropertiesSet.Tables["Properties"].Rows[0]["NumBedrooms"] = System.Convert.ToInt32(NumBedrooms.Text);
                PropertiesSet.Tables["Properties"].Rows[0]["NumBaths"] = System.Convert.ToInt32(NumBaths.Text);
                PropertiesSet.Tables["Properties"].Rows[0]["NumSleeps"] = System.Convert.ToInt32(NumSleeps.Text);
                PropertiesSet.Tables["Properties"].Rows[0]["MinimumNightlyRentalID"] = System.Convert.ToInt32(MinimumNightlyRental.SelectedValue);

                PropertiesSet.Tables["Properties"].Rows[0]["NumTVs"] = System.Convert.ToInt32(NumTVs.Text);
                PropertiesSet.Tables["Properties"].Rows[0]["NumVCRs"] = System.Convert.ToInt32(NumVCRs.Text);
                PropertiesSet.Tables["Properties"].Rows[0]["NumCDPlayers"] = System.Convert.ToInt32(NumCDPlayers.Text);

                PropertiesSet.Tables["Properties"].Rows[0]["Description"] = CommonFunctions.EncodeInput(Description.Text);
                PropertiesSet.Tables["Properties"].Rows[0]["Amenities"] = CommonFunctions.EncodeInput(Amenities.Text);
                PropertiesSet.Tables["Properties"].Rows[0]["LocalAttractions"] = CommonFunctions.EncodeInput(LocalAttractions.Text);
                PropertiesSet.Tables["Properties"].Rows[0]["CancellationPolicy"] = CommonFunctions.EncodeInput(CancellationPolicy.Text);
                PropertiesSet.Tables["Properties"].Rows[0]["DepositRequired"] = CommonFunctions.EncodeInput(DepositRequired.Text);

                PropertiesSet.Tables["Properties"].Rows[0]["RatesTable"] = true;

                if (AuthenticationManager.IfAdmin)
                    PropertiesSet.Tables["Properties"].Rows[0]["IfMoreThan7PhotosAllowed"] =
                        (MoreThan7PhotosAllowed.Items[MoreThan7PhotosAllowed.SelectedIndex].Text == "Yes");

                //lock (CommonFunctions.Connection)
                PropertiesAdapter.Update(PropertiesSet);

                foreach (ListItem item in AmenitiesList.Items)
                    if (item.Text == "TV")
                    {
                        item.Selected = (System.Convert.ToInt32(NumTVs.Text) > 0);
                        break;
                    }

                foreach (ListItem item in AmenitiesList.Items)
                    if (item.Text == "VCR")
                    {
                        item.Selected = (System.Convert.ToInt32(NumVCRs.Text) > 0);
                        break;
                    }

                foreach (ListItem item in AmenitiesList.Items)
                    if (item.Text == "CD Player")
                    {
                        item.Selected = (System.Convert.ToInt32(NumCDPlayers.Text) > 0);
                        break;
                    }

                foreach (ListItem item in AmenitiesList.Items)
                    if (item.Selected)
                    {
                        bool iffound = false;
                        foreach (DataRow datarow in PropertiesAmenitiesSet.Tables["PropertiesAmenities"].Rows)
                            if (datarow.RowState != DataRowState.Deleted)
                                if ((int)datarow["AmenityID"] == Convert.ToInt32(item.Value))
                                {
                                    iffound = true;
                                    break;
                                }

                        if (!iffound)
                        {
                            DataRow newrow = PropertiesAmenitiesSet.Tables["PropertiesAmenities"].NewRow();

                            newrow["PropertyID"] = propertyid;
                            newrow["AmenityID"] = Convert.ToInt32(item.Value);

                            PropertiesAmenitiesSet.Tables["PropertiesAmenities"].Rows.Add(newrow);
                        }
                    }
                    else
                        foreach (DataRow datarow in PropertiesAmenitiesSet.Tables["PropertiesAmenities"].Rows)
                            if (datarow.RowState != DataRowState.Deleted)
                                if ((int)datarow["AmenityID"] == Convert.ToInt32(item.Value))
                                {
                                    datarow.Delete();
                                    break;
                                }

                foreach (DataGridItem item in AttractionsList1.Items)
                {
                    int attractionid = -1;
                    int distanceid = -1;

                    try
                    {
                        attractionid = Convert.ToInt32(AttractionsList1.DataKeys[item.ItemIndex]);
                    }
                    catch (Exception)
                    {
                    }

                    CheckBox checkbox = (CheckBox)item.FindControl("Attraction1");
                    DropDownList dropdown = (DropDownList)item.FindControl("Distance1");

                    try
                    {
                        distanceid = Convert.ToInt32(dropdown.SelectedValue);
                    }
                    catch (Exception)
                    {
                    }

                    if (checkbox.Checked)
                    {
                        bool iffound = false;
                        foreach (DataRow datarow in PropertiesAttractionsSet.Tables["PropertiesAttractions"].Rows)
                            if (datarow.RowState != DataRowState.Deleted)
                                if ((int)datarow["AttractionID"] == attractionid)
                                {
                                    datarow["DistanceID"] = distanceid;
                                    iffound = true;
                                    break;
                                }

                        if (!iffound)
                        {
                            DataRow newrow = PropertiesAttractionsSet.Tables["PropertiesAttractions"].NewRow();

                            newrow["PropertyID"] = propertyid;
                            newrow["AttractionID"] = attractionid;
                            newrow["DistanceID"] = distanceid;

                            PropertiesAttractionsSet.Tables["PropertiesAttractions"].Rows.Add(newrow);
                        }
                    }
                    else
                        foreach (DataRow datarow in PropertiesAttractionsSet.Tables["PropertiesAttractions"].Rows)
                            if (datarow.RowState != DataRowState.Deleted)
                                if ((int)datarow["AttractionID"] == attractionid)
                                {
                                    datarow.Delete();
                                    break;
                                }
                }

                foreach (DataGridItem item in AttractionsList2.Items)
                {
                    int attractionid = -1;
                    int distanceid = -1;

                    try
                    {
                        attractionid = Convert.ToInt32(AttractionsList2.DataKeys[item.ItemIndex]);
                    }
                    catch (Exception)
                    {
                    }

                    CheckBox checkbox = (CheckBox)item.FindControl("Attraction2");
                    DropDownList dropdown = (DropDownList)item.FindControl("Distance2");

                    try
                    {
                        distanceid = Convert.ToInt32(dropdown.SelectedValue);
                    }
                    catch (Exception)
                    {
                    }

                    if (checkbox.Checked)
                    {
                        bool iffound = false;
                        foreach (DataRow datarow in PropertiesAttractionsSet.Tables["PropertiesAttractions"].Rows)
                            if (datarow.RowState != DataRowState.Deleted)
                                if ((int)datarow["AttractionID"] == attractionid)
                                {
                                    datarow["DistanceID"] = distanceid;
                                    iffound = true;
                                    break;
                                }

                        if (!iffound)
                        {
                            DataRow newrow = PropertiesAttractionsSet.Tables["PropertiesAttractions"].NewRow();

                            newrow["PropertyID"] = propertyid;
                            newrow["AttractionID"] = attractionid;
                            newrow["DistanceID"] = distanceid;

                            PropertiesAttractionsSet.Tables["PropertiesAttractions"].Rows.Add(newrow);
                        }
                    }
                    else
                        foreach (DataRow datarow in PropertiesAttractionsSet.Tables["PropertiesAttractions"].Rows)
                            if (datarow.RowState != DataRowState.Deleted)
                                if ((int)datarow["AttractionID"] == attractionid)
                                {
                                    datarow.Delete();
                                    break;
                                }
                }

                int roomid = -1;
                int newid = -1;
                int curroom = 0;

                if (RoomAActive.Checked)
                {
                    if (RoomsSet.Tables["RoomInfo"].Rows.Count > curroom)
                    {
                        roomid = (int)RoomsSet.Tables["RoomInfo"].Rows[curroom]["ID"];
                        RoomsSet.Tables["RoomInfo"].Rows[curroom]["PropertyID"] = propertyid;
                        RoomsSet.Tables["RoomInfo"].Rows[curroom]["RoomTitle"] = RoomATitle.Text;
                    }
                    else
                    {
                        DataRow newroom = RoomsSet.Tables["RoomInfo"].NewRow();

                        if (newid == -1)
                        {
                            object maxid;
                            using (SqlConnection connection = CommonFunctions.GetConnection())
                            {
                                connection.Open();
                                System.Data.SqlClient.SqlCommand getmaxid = new System.Data.SqlClient.SqlCommand(
                                    "SELECT MAX(ID) FROM RoomInfo", connection);

                                maxid = getmaxid.ExecuteScalar();
                                connection.Close();
                            }

                            if (maxid is DBNull)
                                roomid = 1;
                            else
                                roomid = (int)maxid + 1;
                            newid = roomid + 1;
                        }
                        else
                        {
                            roomid = newid;
                            newid++;
                        }

                        newroom["ID"] = roomid;
                        newroom["PropertyID"] = propertyid;
                        newroom["RoomTitle"] = RoomATitle.Text;

                        RoomsSet.Tables["RoomInfo"].Rows.Add(newroom);
                    }

                    SaveRoomList(roomid, RoomAList);

                    curroom++;
                }

                if (RoomBActive.Checked)
                {
                    if (RoomsSet.Tables["RoomInfo"].Rows.Count > curroom)
                    {
                        roomid = (int)RoomsSet.Tables["RoomInfo"].Rows[curroom]["ID"];
                        RoomsSet.Tables["RoomInfo"].Rows[curroom]["PropertyID"] = propertyid;
                        RoomsSet.Tables["RoomInfo"].Rows[curroom]["RoomTitle"] = RoomBTitle.Text;
                    }
                    else
                    {
                        DataRow newroom = RoomsSet.Tables["RoomInfo"].NewRow();

                        if (newid == -1)
                        {
                            object maxid;
                            using (SqlConnection connection = CommonFunctions.GetConnection())
                            {
                                connection.Open();
                                System.Data.SqlClient.SqlCommand getmaxid = new System.Data.SqlClient.SqlCommand(
                                    "SELECT MAX(ID) FROM RoomInfo", connection);

                                maxid = getmaxid.ExecuteScalar();
                                connection.Close();
                            }

                            if (maxid is DBNull)
                                roomid = 1;
                            else
                                roomid = (int)maxid + 1;
                            newid = roomid + 1;
                        }
                        else
                        {
                            roomid = newid;
                            newid++;
                        }

                        newroom["ID"] = roomid;
                        newroom["PropertyID"] = propertyid;
                        newroom["RoomTitle"] = RoomBTitle.Text;

                        RoomsSet.Tables["RoomInfo"].Rows.Add(newroom);
                    }

                    SaveRoomList(roomid, RoomBList);

                    curroom++;
                }

                if (RoomCActive.Checked)
                {
                    if (RoomsSet.Tables["RoomInfo"].Rows.Count > curroom)
                    {
                        roomid = (int)RoomsSet.Tables["RoomInfo"].Rows[curroom]["ID"];
                        RoomsSet.Tables["RoomInfo"].Rows[curroom]["PropertyID"] = propertyid;
                        RoomsSet.Tables["RoomInfo"].Rows[curroom]["RoomTitle"] = RoomCTitle.Text;
                    }
                    else
                    {
                        DataRow newroom = RoomsSet.Tables["RoomInfo"].NewRow();

                        if (newid == -1)
                        {
                            object maxid = null;
                            using (SqlConnection connection = CommonFunctions.GetConnection())
                            {
                                connection.Open();
                                System.Data.SqlClient.SqlCommand getmaxid = new System.Data.SqlClient.SqlCommand(
                                    "SELECT MAX(ID) FROM RoomInfo", connection);

                                maxid = getmaxid.ExecuteScalar();
                                connection.Close();
                            }

                            if (maxid is DBNull)
                                roomid = 1;
                            else
                                roomid = (int)maxid + 1;
                            newid = roomid + 1;
                        }
                        else
                        {
                            roomid = newid;
                            newid++;
                        }

                        newroom["ID"] = roomid;
                        newroom["PropertyID"] = propertyid;
                        newroom["RoomTitle"] = RoomCTitle.Text;

                        RoomsSet.Tables["RoomInfo"].Rows.Add(newroom);
                    }

                    SaveRoomList(roomid, RoomCList);

                    curroom++;
                }

                if (RoomDActive.Checked)
                {
                    if (RoomsSet.Tables["RoomInfo"].Rows.Count > curroom)
                    {
                        roomid = (int)RoomsSet.Tables["RoomInfo"].Rows[curroom]["ID"];
                        RoomsSet.Tables["RoomInfo"].Rows[curroom]["PropertyID"] = propertyid;
                        RoomsSet.Tables["RoomInfo"].Rows[curroom]["RoomTitle"] = RoomDTitle.Text;
                    }
                    else
                    {
                        DataRow newroom = RoomsSet.Tables["RoomInfo"].NewRow();

                        if (newid == -1)
                        {
                            object maxid = null;
                            using (SqlConnection connection = CommonFunctions.GetConnection())
                            {
                                connection.Open();
                                System.Data.SqlClient.SqlCommand getmaxid = new System.Data.SqlClient.SqlCommand(
                                    "SELECT MAX(ID) FROM RoomInfo", connection);

                                maxid = getmaxid.ExecuteScalar();
                                connection.Close();
                            }

                            if (maxid is DBNull)
                                roomid = 1;
                            else
                                roomid = (int)maxid + 1;
                            newid = roomid + 1;
                        }
                        else
                        {
                            roomid = newid;
                            newid++;
                        }

                        newroom["ID"] = roomid;
                        newroom["PropertyID"] = propertyid;
                        newroom["RoomTitle"] = RoomDTitle.Text;

                        RoomsSet.Tables["RoomInfo"].Rows.Add(newroom);
                    }

                    SaveRoomList(roomid, RoomDList);

                    curroom++;
                }

                if (RoomEActive.Checked)
                {
                    if (RoomsSet.Tables["RoomInfo"].Rows.Count > curroom)
                    {
                        roomid = (int)RoomsSet.Tables["RoomInfo"].Rows[curroom]["ID"];
                        RoomsSet.Tables["RoomInfo"].Rows[curroom]["PropertyID"] = propertyid;
                        RoomsSet.Tables["RoomInfo"].Rows[curroom]["RoomTitle"] = RoomETitle.Text;
                    }
                    else
                    {
                        DataRow newroom = RoomsSet.Tables["RoomInfo"].NewRow();

                        if (newid == -1)
                        {
                            object maxid = null;
                            using (SqlConnection connection = CommonFunctions.GetConnection())
                            {
                                connection.Open();
                                System.Data.SqlClient.SqlCommand getmaxid = new System.Data.SqlClient.SqlCommand(
                                    "SELECT MAX(ID) FROM RoomInfo", connection);

                                maxid = getmaxid.ExecuteScalar();
                                connection.Close();
                            }

                            if (maxid is DBNull)
                                roomid = 1;
                            else
                                roomid = (int)maxid + 1;
                            newid = roomid + 1;
                        }
                        else
                        {
                            roomid = newid;
                            newid++;
                        }

                        newroom["ID"] = roomid;
                        newroom["PropertyID"] = propertyid;
                        newroom["RoomTitle"] = RoomETitle.Text;

                        RoomsSet.Tables["RoomInfo"].Rows.Add(newroom);
                    }

                    SaveRoomList(roomid, RoomEList);

                    curroom++;
                }

                for (int i = curroom; i < RoomsSet.Tables["RoomInfo"].Rows.Count; i++)
                    RoomsSet.Tables["RoomInfo"].Rows[i].Delete();

                //lock (CommonFunctions.Connection)
                PropertiesAmenitiesAdapter.Update(PropertiesAmenitiesSet);
                //lock (CommonFunctions.Connection)
                PropertiesAttractionsAdapter.Update(PropertiesAttractionsSet);
                //lock (CommonFunctions.Connection)
                RoomsAdapter.Update(RoomsSet);
                //lock (CommonFunctions.Connection)
                RoomFurnitureItemsAdapter.Update(RoomFurnitureItemsSet);
                //lock (CommonFunctions.Connection)
                RatesAdapter.Update(RatesSet);
                //lock (CommonFunctions.Connection)
                PropertiesPaymentMethodsAdapter.Update(PropertiesPaymentMethodsSet);
                if (ifadd)
                    Response.Redirect(CommonFunctions.PrepareURL("PropertyPhotos.aspx?UserID=" + userid.ToString() +
                        "&PropertyID=" + propertyid.ToString() + "&BackLink=EditAmenitiesAndAttractions.aspx%3F" +
                        System.Web.HttpUtility.UrlEncode(Request.QueryString.ToString())));
                else
                    Response.Redirect(backlinkurl);
        }
        catch (Exception ex) { lblInfo.Text = ex.Message; }
    }

    private void SaveRoomList(int roomid, CheckBoxList list)
    {
        foreach (ListItem item in list.Items)
            if (item.Selected)
            {
                bool iffound = false;
                foreach (DataRow datarow in RoomFurnitureItemsSet.Tables["RoomFurnitureItems"].Rows)
                    if (datarow.RowState != DataRowState.Deleted)
                        if (((int)datarow["RoomID"] == roomid) &&
                            ((int)datarow["FurnitureItemID"] == Convert.ToInt32(item.Value)))
                        {
                            iffound = true;
                            break;
                        }

                if (!iffound)
                {
                    DataRow newrow = RoomFurnitureItemsSet.Tables["RoomFurnitureItems"].NewRow();

                    newrow["RoomID"] = roomid;
                    newrow["FurnitureItemID"] = Convert.ToInt32(item.Value);

                    RoomFurnitureItemsSet.Tables["RoomFurnitureItems"].Rows.Add(newrow);
                }
            }
            else
                foreach (DataRow datarow in RoomFurnitureItemsSet.Tables["RoomFurnitureItems"].Rows)
                    if (datarow.RowState != DataRowState.Deleted)
                        if (((int)datarow["RoomID"] == roomid) &&
                            ((int)datarow["FurnitureItemID"] == Convert.ToInt32(item.Value)))
                        {
                            datarow.Delete();
                            break;
                        }
    }
}
