using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectStockSystem
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Session["Panel"] = ;
        DataTable dtBilgiler = new DataTable();
        DataTable dtSecilenMalzemeler = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            FacultyWorksEntities db = new FacultyWorksEntities();
            var kullanıcıId = Session["UserName"];
            int kullanıcıIdSession = Convert.ToInt32(kullanıcıId);
            Ogrenci m =
                db.Ogrenci.FirstOrDefault(
                    x => x.kullanıcı_id == kullanıcıIdSession);

            Danisman d = db.Danisman.FirstOrDefault(
                    x => x.danisman_id == m.kullanıcı_danisman_id);
            if (!Page.IsPostBack)
            {
                wzStudent.ActiveStepIndex = 0;
                var reservationKey = GenerateKey().ToUpper();
                rzTxtbox.Text = reservationKey;
                tcTxtbox.Text = m.kullanıcı_id.ToString();
                nameTxtbox.Text = m.kullanıcı_adi;
                surnameTxtbox.Text = m.kullanıcı_soyadi;
                dptTxtbox.Text = m.kullanıcı_bolumu;
                TxtboxDanisman.Text = d.danisman_adi + " " + d.danisman_soyadi;
                Session["tel"] = telTxtbox.Text;
            }

            if (m.kullanıcı_adi != null)
            {
                loginName.Text = m.kullanıcı_adi;
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
            //üçüncü sayfada grup arkadaşı eklemek için prerender
            dtBilgiler.Columns.AddRange(new DataColumn[4] { new DataColumn("Öğrenci Id"), new DataColumn("Öğrenci Adı"), new DataColumn("Öğrenci Soyadı"), new DataColumn("Öğrenci Bölümü") });
            if (ViewState["bilgiler"] != null)
            {
                dtBilgiler = (DataTable)ViewState["bilgiler"];
                gwSecilenOgrenci.DataSource = dtBilgiler;
                gwSecilenOgrenci.DataBind();
            }
            //malzeme seçmek için prerender
            dtSecilenMalzemeler.Columns.AddRange(new DataColumn[6] { new DataColumn("Malzeme Adı"), new DataColumn("Malzeme Seri No"), new DataColumn("Malzeme Kodu"), new DataColumn("Malzeme Durumu"), new DataColumn("Malzeme Tipi"), new DataColumn("Çalışma Türü") });
            if (ViewState["SecilenMalzemeler"] != null)
            {
                dtSecilenMalzemeler = (DataTable)ViewState["SecilenMalzemeler"];
                GridViewSeçilenMalzemeList.DataSource = dtSecilenMalzemeler;
                GridViewSeçilenMalzemeList.DataBind();
            }
            wzStudent.PreRender += new EventHandler(WzStudentPreRender);
        }

        protected void WzStudentPreRender(object sender, EventArgs e)
        {
            Repeater SideBarList = wzStudent.FindControl("HeaderContainer").FindControl("SideBarList") as Repeater;
            SideBarList.DataSource = wzStudent.WizardSteps;
            SideBarList.DataBind();

        }

        protected string GetClassForWizardStep(object wizardStep)
        {
            WizardStep step = wizardStep as WizardStep;

            if (step == null)
            {
                return "";
            }
            int stepIndex = wzStudent.WizardSteps.IndexOf(step);

            if (stepIndex < wzStudent.ActiveStepIndex)
            {
                return "prevStep";
            }
            else if (stepIndex > wzStudent.ActiveStepIndex)
            {
                return "nextStep";
            }
            else
            {
                return "currentStep";
            }
        }

        protected void logOutButton_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Session.Abandon();
            Session.RemoveAll();
            Response.Redirect("Login.aspx", true);
        }

        public static string GenerateKey()
        {
            long i = 1;
            foreach (byte b in Guid.NewGuid().ToByteArray())
            {
                i *= ((int)b + 1);
            }
            return string.Format("{0:x}", i - DateTime.Now.Ticks);
        }

        protected void wzStudent_NextButtonClick(object sender, WizardNavigationEventArgs e)
        {
            /*
            switch (wzStudent.WizardSteps[e.NextStepIndex].ID)
            {
                case "wzStudentDetails":
                    break;
                case "wzStudentCourseAndAssistant":
                    String calismaTipi = Ddlcalismatürü.Text;
                    String secilenDers = DdlDersler.Text;
                    Ddlcalismatürü.SelectedIndex = Ddlcalismatürü.Items.IndexOf(Ddlcalismatürü.Items.FindByText(HttpUtility.HtmlDecode(calismaTipi)));
                    DdlDersler.SelectedIndex =
                        DdlDersler.Items.IndexOf(DdlDersler.Items.FindByText(HttpUtility.HtmlDecode(secilenDers)));
                    break;
                case "wzStudentGroupDetails":
                    break;
                case "wzStudentMaterial":
                    break;


            }
            */
            Session["tel"] = telTxtbox.Text;
        }

        protected void wzStudent_PreviousButtonClick(object sender, WizardNavigationEventArgs e)
        {

            telTxtbox.Text = Session["tel"].ToString();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            FacultyWorksEntities db = new FacultyWorksEntities();
            var secilenOgrenci = Convert.ToInt32(tcSecilenOgrenci.Text);
            Ogrenci m =
               db.Ogrenci.FirstOrDefault(
                   x => x.kullanıcı_id == secilenOgrenci);
            if (m != null)
            {
                dtBilgiler.Rows.Add(m.kullanıcı_id, m.kullanıcı_adi, m.kullanıcı_soyadi, m.kullanıcı_bolumu);
                ViewState["bilgiler"] = dtBilgiler;
                gwSecilenOgrenci.DataSource = dtBilgiler;
                gwSecilenOgrenci.DataBind();

            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Kullanıcı bulunamadı')", true);
            }

        }

        protected void DdlMalzemeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tip;
            int.TryParse(DdlMalzemeList.SelectedValue, out tip);
            using (var entities = new FacultyWorksEntities())
            {
                var items = entities.Malzeme.Where(m => m.malzeme_tipi == tip).ToList();
                if (tip == 0)
                {
                    GridViewMalzemeList.DataSource = entities.Malzeme.ToList();
                    GridViewMalzemeList.DataBind();
                }
                else
                {
                    GridViewMalzemeList.DataSource = items;
                    GridViewMalzemeList.DataBind();
                }

            }
            //FacultyWorksEntities db = new FacultyWorksEntities();
            //GridViewMalzemeList.DataSource =
            //   db.Database.SqlQuery<List<Malzeme,MalzemeDurumu,MalzemeTipi>>(
            //       "select Malzeme.malzeme_id, Malzeme.malzeme_adi, OgrenciCalismaTuru.calisma_turu, MalzemeDurumu.durum_adi, Malzeme.malzeme_serino, Malzeme.malzeme_kodu, MalzemeTipi.tip_adi from Malzeme inner join MalzemeTipi on Malzeme.malzeme_tipi = MalzemeTipi.tip_id inner join OgrenciCalismaTuru on OgrenciCalismaTuru.calisma_id = Malzeme.malzeme_calisma_grubu inner join MalzemeDurumu on MalzemeDurumu.durum_id = Malzeme.malzeme_durumu where MalzemeTipi.tip_adi like'%" +
            //       DdlMalzemeList.SelectedItem.Text + "'").ToList();
            //GridViewMalzemeList.DataBind();
        }

        protected void GridViewMalzemeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GridViewMalzemeList.SelectedRow;
            if (row.RowType == DataControlRowType.DataRow)
            {
                string malzemeAdı = HttpUtility.HtmlDecode(row.Cells[1].Text);
                string malzemeSeri = HttpUtility.HtmlDecode(row.Cells[2].Text);
                string malzemeKodu = HttpUtility.HtmlDecode(row.Cells[3].Text);
                string malzemeDurumu = HttpUtility.HtmlDecode(row.Cells[4].Text);
                string malzemeTipi = HttpUtility.HtmlDecode(row.Cells[5].Text);
                string malzemeTuru = HttpUtility.HtmlDecode(row.Cells[6].Text);
                dtSecilenMalzemeler.Rows.Add(malzemeAdı, malzemeSeri, malzemeKodu, malzemeDurumu, malzemeTipi, malzemeTuru);
            }
            ViewState["SecilenMalzemeler"] = dtSecilenMalzemeler;
            GridViewSeçilenMalzemeList.DataSource = dtSecilenMalzemeler;
            GridViewSeçilenMalzemeList.DataBind();
            //GridViewSeçilenMalzemeList.Columns[1].Visible = false;

        }




        protected void DdlMalzemeList_DataBound(object sender, EventArgs e)
        {
            DdlMalzemeList.Items.Insert(0, new ListItem("Tümü", "0"));
        }

        protected void GridViewMalzemeList_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridViewMalzemeList.PageIndex = e.NewPageIndex;
            GridViewMalzemeList.DataBind();
        }

        protected void wzStudent_FinishButtonClick(object sender, WizardNavigationEventArgs e)
        {

        }


        protected void btnHukuksalDokuman_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        protected void btnOduncKilavuz_Click(object sender, EventArgs e)
        {
            string url = "Popup.aspx";
            string s = "window.open('" + url + "', 'popup_window', 'width=300,height=100,left=100,top=100,resizable=yes');";
            ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);

        }
    }
}