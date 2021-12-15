namespace Winforms_calc;

public partial class Form1 : Form
{
     private string leTexte;
    public Form1()
    {
        InitializeComponent();
         btnRecopier.Click += btnRecopier_Click;
         btnEffacer.Click += btnEffacer_Click;
         btnQuitter.Click += btnQuitter_Click;
         this.input.GotFocus += new EventHandler(txtInput_GotFocus);
         this.leTexte = "Entrer le texte initial";
        this.input.Text = leTexte;
        this.Height = 400;
    }

    private void btnRecopier_Click(object sender, EventArgs e)
    {
        this.lblResultat.Text = this.input.Text;
    }
    private void btnEffacer_Click(object sender, EventArgs e)
    {
        this.input.Text = this.leTexte;
        this.lblResultat.Text = "";
    }
    private void btnQuitter_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show("Voulez vous vraiment quitter", "Terminer ?", MessageBoxButtons.OKCancel) == DialogResult.OK)
        {
            Application.Exit();
        }
    }
    private void Form1_Load(object sender, EventArgs e)
    {
        this.input.Text = "Entrer le texte initial";
    }
    private void txtInput_GotFocus(object sender, EventArgs e)
    {
        this.input.Text = "";
    }
    private void chkModifier_CheckedChanged(object sender, EventArgs e)
    {
        this.gbxCouleur.Visible = this.chkModifier.Checked;
        this.Height = this.chkModifier.Checked ? 800 : 400;
    }
    private void rbColor_CheckedChanged(object sender, EventArgs e){
        if(this.rbVert.Checked){
            this.lblColor.BackColor = System.Drawing.Color.Green;
        }else if(this.rbRouge.Checked){
              this.lblColor.BackColor = System.Drawing.Color.Red;
        }else{
              this.lblColor.BackColor = System.Drawing.Color.Blue;
        }
       
    }

}

