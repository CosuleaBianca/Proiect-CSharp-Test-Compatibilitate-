using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_de_compatibilitate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int i = 1, scor = 0, p = 1, j;

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            j = 1;
            titlu.Visible = false;
            button2.Visible = false;
            picture1.Visible = false;
            picture2.Visible = false;
            picture3.Visible = false;

            picture4.Visible = true;
            pictureceas.Visible = true;
            label5.Text = "Pasul 1 : Decizia";
            label5.Visible = true;

            richTextBox1.Text = "      Iepurașii pot fi niște companioni cu adevărat minunați dacă sunt aleși de cine trebuie. Sunt animale curate, liniștite și extrem de adorabile! Dar înainte de a-l alege ca și animal de companie, trebuie să te asiguri că este animalul potrivit pentru tine și familia ta, și că ești pregătit pentru o responsabilitate pe termen lung ( durata medie de viață a unui iepure de companie fiind de aproximativ 8 până la 12 ani). \n      Pe urmă trebuie să te gandești dacă îți poți permite financiar să îngrijești un astfel de animaluț :  taxa de adopție, costurile unei sterilizări, controale anuale la veterinar, tratamentele pentru unele boli care pot apărea, și nu în ultimul rând, mâncarea. \n      Datorită responsabilităților mari pe care le presupune îngrijirea unui iepuraș, acesta nu este un animal potrivit pentru copii, care se plictisesc repede neglijându-l considerabil. \n      Un iepuraș are nevoie de timp și spațiu, așa că fii pregătit să i le oferi.";
            richTextBox1.Visible = true;
            pictureBox2.ImageLocation = "arrow.png";
            pictureBox3.ImageLocation = "arrowb.png";
            pictureBox3.Visible = false;

        }

        private void titlu_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxArrow_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            j++;
            if (j > 1) pictureBox3.Visible = true;
            else pictureBox3.Visible = false;
            if (j == 2)
            {
                label5.Text = "Pasul 2 : Pregătirea casei ";
                richTextBox1.Text = "      Primul lucru pe care trebuie să îl faci atunci când te hotăraști să aduci un iepuraș acasă este sa decizi locul în care acesta va sta cea mai mare parte din timp. Este recomandat ca iepurașul să trăiască în casă, alături de tine, unde este protejat de prădători si de vremea rea. \n      Un loc bun în care iepurașul își  poate petrece timpul este în zona centrală a casei tale. Poți folosi un țarc pentru căței pentru a bloca zonele în care acesta nu are voie. Un astfel de țarc este o soluție buna atunci când nu ai posibilitatea de a-l lăsa liber in toată casa tot timpul. Deoarece țarcurile pentru cățeluși au adesea si o portiță, este usor să-ți lași iepurașul afară petru a-și face exercițiile zilnice. \n Lucrurile de care un iepuraș are nevoie: \n \n         - litieră; \n         - așternut igienic din lemn sau hârtie; \n         - boluri pentru apă si mâncare; \n         - suport pentru fân; \n         - ascunzatoare/căsuță; \n         - jucării de ros. \n \n \n    ";
                picture4.Visible = false;
                pictureceas.Visible = false;
                picture5.Visible = true;


            }
            else if (j == 3)
            {
                label5.Text = "Pasul 3 : Alimentația ";
                richTextBox1.Text = "      Iepurii au o dietă bazată in proporție de 80% pe fân, ce nu trebuie să lipsească niciodată din alimentația lor. Iepurii adulți pot consuma fân de timoftică, ovăz sau de pajiște. În plus, in proporție de 20%, dieta lor ar trebui să cuprindă: \n         - pelete pentru iepuri;\n         - legume (brocolli, sparanghel, morcovi, castravete, ardei, păstârnac, dovleac, ridiche) și fructe (măr, banană, struguri, pepene,capșune, afine, zmeură) , legumele pot fi hrănite in cantități mici zilnic , pe când fructele trebuie hrănite cel mult de două ori pe săptămână, datorită conținutului ridicat de zahăr; \n        - verdețuri (salată, spanac, ștevie, lobodă, frunze de morcov, frunze de ridiche); \n        - ierburi (iarbă, busuioc, coriandru, mărar, pătrunjel, oregano, mentă, rucola); \n        - apă proaspătă, tot timpul.";
                picture5.Visible = false;
                picture6.Visible = true;
            }
            else if (j == 4)
            {
                label5.Text = "Pasul 4 : Igiena ";
                richTextBox1.Text = "      Iepurii se aseamănă destul de mult cu pisicile la acest capitol, deoarece se curața singuri si sunt niște animale foarte curate. Cu toate acestea, au nevoie de ajutorul tău să le periezi blana pentru a scăpa de exces. Iepurii se pot îmbolnăvii dacă ingerează prea mult păr în procesul de toaletare, deoarece spre deosebire de pisici, care își vomită părul ajuns în stomac, nu au această capacitate iar bilele de păr ingerate pot provoca blocaje in tractul gastrointestinal. Iepurașii cu blana lungă au nevoie de o atenție sporită la acest capitol. \n De asemenea este important și sa le scurtezi unghiile periodic pentru a le păstra lăbuțele sănătoase.\n      Iepurii nu au nevoie să li se facă baie, cu toate acestea, dacă se murdăresc foarte tare, poți folosi servețele umede de bebeluși sau animale pentru a-i curăța. Evită pe cât posibil contactul lor cu apa deoarece este considerată o experiență traumatizantă. ";
                picture6.Visible = false;
                picture7.Visible = true;
                picture8.Visible = true;
            }
            else
            {
                picture7.Visible = false;
                picture8.Visible = false;
                pictureBox2.Visible = false;
                label5.Text = "Pasul 5 : Timpul petrecut împreună ";
                richTextBox1.Text = "      Iepurele este un animal sociabil, așadar nu ar fi o idee rea să îți iei o pereche, astfel evitând plictiseala, dar aceasta este o alegere potențial riscantă, căci într-un spațiu prea mic, masculii si femelele ajung adeseori sa se lupte intre ei. Indiferent câți iepurași ai avea, interacțiunea ta cu ei este obligatorie. Este recomandat ca în fiecare zi iepurașii să aibă parte de măcar 2 – 3 ore de libertate controlata(în cazul în care nu sunt ținuți liberi prin casă), în care să alerge, să se joace și să vă împrieteniți. Îl poți hrăni din mână, îl poți peria, și după ce se obișnuieste cu tine și începe să te considere prieten poate că îi va face plăcere inclusiv sa îl ții în brațe. Poate pare ciudat, însa iepurii sunt animale jucăușe.\nExista chiar și jucării pentru iepurași, care să-l țină ocupat cât timp tu nu ești prin preajmă. \n      Amintește-ți, un iepuraș este un angajament, așa că bucură-te de el ! Petrece timp cu iepurașul tău și arată-ți dragostea prin sărutări și mângâieri. Cine știe, iepurașul tău s-ar putea să-ți întoarcă favoarea!\n      Ai ajuns la finalul acestui ghid ! Dacă vei dori să-ți testezi relatia dintre tine si iepurașul tău, sau ești deja ''părinte'' de iepuraș, ai aici un test de compatibilitate cu valoare orientativa pe care îl poți face :";
                button3.Visible = true;
                button3.Text = "Test";
                picture9.Visible = true;

            }
           
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            j--;
            if (j > 1) pictureBox3.Visible = true;
            else pictureBox3.Visible = false;

            if (j == 1)
            {
                label5.Text = "Pasul 1 : Decizia";
                label5.Visible = true;
                picture4.Visible = true;
                pictureceas.Visible = true;


                richTextBox1.Text = "      Iepurașii pot fi niște companioni cu adevărat minunați dacă sunt aleși de cine trebuie. Sunt animale curate, liniștite și extrem de adorabile! Dar înainte de a-l alege ca și animal de companie, trebuie să te asiguri că este animalul potrivit pentru tine și familia ta, și că ești pregătit pentru o responsabilitate pe termen lung ( durata medie de viață a unui iepure de companie fiind de aproximativ 8 până la 12 ani). \n      Pe urmă trebuie să te gandești dacă îți poți permite financiar să îngrijești un astfel de animaluț :  taxa de adopție, costurile unei sterilizări, controale anuale la veterinar, tratamentele pentru unele boli care pot apărea, și nu în ultimul rând, mâncarea. \n      Datorită responsabilităților mari pe care le presupune îngrijirea unui iepuraș, acesta nu este un animal potrivit pentru copii, care se plictisesc repede neglijându-l considerabil. \n      Un iepuraș are nevoie de timp și spațiu, așa că fii pregătit să i le oferi.";
                richTextBox1.Visible = true;
                picture5.Visible = false;
            }
            else if (j == 2)
            {
                label5.Text = "Pasul 2 : Pregătirea casei ";
                richTextBox1.Text = "      Primul lucru pe care trebuie să îl faci atunci când te hotăraști să aduci un iepuraș acasă este sa decizi locul în care acesta va sta cea mai mare parte din timp. Este recomandat ca iepurașul să trăiască în casă, alături de tine, unde este protejat de prădători si de vremea rea. \n      Un loc bun în care iepurașul își  poate petrece timpul este în zona centrală a casei tale. Poți folosi un țarc pentru căței pentru a bloca zonele în care acesta nu are voie. Un astfel de țarc este o soluție buna atunci când nu ai posibilitatea de a-l lăsa liber in toată casa tot timpul. Deoarece țarcurile pentru cățeluși au adesea si o portiță, este usor să-ți lași iepurașul afară petru a-și face exercițiile zilnice. \n Lucrurile de care un iepuraș are nevoie: \n \n         - litieră; \n         - așternut igienic din lemn sau hârtie; \n         - boluri pentru apă si mâncare; \n         - suport pentru fân; \n         - ascunzatoare/căsuță; \n         - jucării de ros. \n \n \n       ";
                picture5.Visible = true;
                picture6.Visible = false;

            }
            else if (j == 3)
            {
                label5.Text = "Pasul 3 : Alimentația ";
                richTextBox1.Text = "      Iepurii au o dietă bazată in proporție de 80% pe fân, ce nu trebuie să lipsească niciodată din alimentația lor. Iepurii adulți pot consuma fân de timoftică, ovăz sau de pajiște. În plus, in proporție de 20%, dieta lor ar trebui să cuprindă: \n         - pelete pentru iepuri;\n         - legume (brocolli, sparanghel, morcovi, castravete, ardei, păstârnac, dovleac, ridiche) și fructe (măr, banană, struguri, pepene,capșune, afine, zmeură) , legumele pot fi hrănite in cantități mici zilnic , pe când fructele trebuie hrănite cel mult de două ori pe săptămână, datorită conținutului ridicat de zahăr; \n        - verdețuri (salată, spanac, ștevie, lobodă, frunze de morcov, frunze de ridiche); \n        - ierburi (iarbă, busuioc, coriandru, mărar, pătrunjel, oregano, mentă, rucola); \n        - apă proaspătă, tot timpul.";
                picture6.Visible = true;
                picture7.Visible = false;
                picture8.Visible = false;
            }
            else if (j == 4)
            {
                label5.Text = "Pasul 4 : Igiena ";
                richTextBox1.Text = "      Iepurii se aseamănă destul de mult cu pisicile la acest capitol, deoarece se curața singuri si sunt niște animale foarte curate. Cu toate acestea, au nevoie de ajutorul tău să le periezi blana pentru a scăpa de exces. Iepurii se pot îmbolnăvii dacă ingerează prea mult păr în procesul de toaletare, deoarece spre deosebire de pisici, care își vomită părul ajuns în stomac, nu au această capacitate iar bilele de păr ingerate pot provoca blocaje in tractul gastrointestinal. Iepurașii cu blana lungă au nevoie de o atenție sporită la acest capitol. \n De asemenea este important și sa le scurtezi unghiile periodic pentru a le păstra lăbuțele sănătoase.\n      Iepurii nu au nevoie să li se facă baie, cu toate acestea, dacă se murdăresc foarte tare, poți folosi servețele umede de bebeluși sau animale pentru a-i curăța. Evită pe cât posibil contactul lor cu apa deoarece este considerată o experiență traumatizantă. ";
                pictureBox2.Visible = true;
                button3.Visible = false;
                picture7.Visible = true;
                picture8.Visible = true;
                picture9.Visible = false;
            }

        }

        private void picture4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void intrebare_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label5.Visible = false;
            richTextBox1.Visible = false;
            button3.Visible = false;
            pictureBox3.Visible = false;
            picture9.Visible = false;
            label1.Visible = true;
            label2.Visible = true;
            button1.Visible = true;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            button1.Visible = false;

            MessageBox.Show("Pentru fiecare întrebare alegeți o singură variantă de răspuns.", "Reguli", MessageBoxButtons.OK, MessageBoxIcon.Information);
            intrebare.Text = "1. În ce perioadă a zilei ai cel mai mult timp liber?";
            radioButton1.Text = "dimineața";
            radioButton2.Text = "la prânz";
            radioButton3.Text = "seara";
            intrebare.Visible = true;
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = true;
            buttonNext.Visible = true;
            picture10.Visible = true;


        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false)
                MessageBox.Show("Alegeți o variantă de răspuns", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            else if (i == 1)
            {
                if (radioButton1.Checked == true || radioButton3.Checked == true) scor += 10;

                i++;

                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                picture10.Size =  new Size(400,319);
                picture10.ImageLocation = "gif2.gif";
                picture10.Location = new Point(650, 75);

                intrebare.Text = "2. Ce spațiu îi oferi iepurașului?";
                radioButton1.Text = "o cușcă";
                radioButton2.Text = "un țarc";
                radioButton3.Text = "toată casa";
            }
            else if (i == 2)
            {
                if (radioButton2.Checked == true) scor += 5;
                else if (radioButton3.Checked == true) scor += 10;

                i++;

                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                picture10.Size = new Size(300, 320);
                picture10.ImageLocation = "poza16.png";

                intrebare.Text = "3. Cât timp petreceți împreună?";
                radioButton1.Text = "câteva ore pe zi";
                radioButton2.Text = "o oră";
                radioButton3.Text = "mai puțin de o oră";
            }
            else if (i == 3)
            {
                if (radioButton2.Checked == true) scor += 5;
                else if (radioButton1.Checked == true) scor += 10;

                i++;

                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                picture10.Size = new Size(500, 344);
                picture10.ImageLocation = "gif3.gif";
                picture10.Location = new Point(620, 75);


                intrebare.Text = "4. Cât de des îi oferi iepurașului gustări?";
                radioButton1.Text = "de 3-4 ori pe săptămână";
                radioButton2.Text = "o dată pe săptămână";
                radioButton3.Text = "niciodată";
            }
            else if (i == 4)
            {
                if (radioButton2.Checked == true) scor += 5;
                else if (radioButton1.Checked == true) scor += 10;

                i++;

                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                picture10.Size = new Size(350,300);
                picture10.ImageLocation = "poza17.jpg";
                picture10.Location = new Point(520, 200);


                intrebare.Text = "5. Atunci când îi pregătești mâncarea, iepurașul îți încercuiește picioarele?";
                radioButton1.Text = "da";
                radioButton2.Text = "nu";
                radioButton3.Text = "câteodată";
            }
            else if (i == 5)
            {
                if (radioButton3.Checked == true) scor += 5;
                else if (radioButton1.Checked == true) scor += 10;

                i++;

                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                picture10.Size = new Size(300, 168);
                picture10.ImageLocation = "poza18.jpg";
                picture10.Location = new Point(580, 250);


                intrebare.Text = "6. Cum se comportă iepurașul tău când nu ești prin preajmă?";
                radioButton1.Text = "te caută";
                radioButton2.Text = "doarme";
                radioButton3.Text = "e indiferent";
            }
            else if (i == 6)
            {
                if (radioButton2.Checked == true) scor += 5;
                else if (radioButton1.Checked == true) scor += 10;

                i++;

                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                picture10.Size = new Size(500, 243);
                picture10.ImageLocation = "gif4.gif";
                picture10.Location = new Point(500, 250);


                intrebare.Text = "7. Cât de des țopaie iepurașul când ești în preajma lui?";
                radioButton1.Text = "destul de des";
                radioButton2.Text = "câteodată";
                radioButton3.Text = "niciodată";
            }
            else if (i == 7)
            {
                if (radioButton2.Checked == true) scor += 5;
                else if (radioButton1.Checked == true) scor += 10;

                i++;

                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                picture10.Size = new Size(300,480 );
                picture10.ImageLocation = "poza20.png";
                picture10.Location = new Point(780, 30);

                intrebare.Text = "8. Cât de tare te superi când iepurașul roade ceva?";
                radioButton1.Text = "puțin, însă îl iert imediat";
                radioButton2.Text = "nu mă supăr";
                radioButton3.Text = "mă supăr și îl pedepsesc";
            }
            else if (i == 8)
            {
                if (radioButton2.Checked == true) scor += 5;
                else if (radioButton1.Checked == true) scor += 10;

                i++;

                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                picture10.Size = new Size(292, 350);
                picture10.ImageLocation = "poza19.jpg";
                picture10.Location = new Point(500, 200);

                intrebare.Text = "9. Cum reacționează iepurașul tău când simte mirosul altui animal la tine?";
                radioButton1.Text = "te miroase și fuge";
                radioButton2.Text = "te marchează cu mirosul lui";
                radioButton3.Text = "este indiferent";
            }
            else if (i == 9)
            {
                if (radioButton1.Checked == true) scor += 5;
                else if (radioButton2.Checked == true) scor += 10;

                i++;

                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                picture10.Size = new Size(300, 400);
                picture10.ImageLocation = "gif5.gif";
                picture10.Location = new Point(650, 75);

                intrebare.Text = "10. Unde fuge iepurașul când este speriat?";
                radioButton1.Text = "la tine în brațe";
                radioButton2.Text = "sub pat sau alt loc retras";
                radioButton3.Text = "nu fuge, încremenește";
                buttonNext.Text = "Finalizare";
            }
            else if (i == 10)
            {
                if (radioButton2.Checked == true) scor += 5;
                else if (radioButton1.Checked == true) scor += 10;
                i++;

                intrebare.Visible = false;
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                picture10.Visible = false;
                buttonNext.Text = "Ieșire";
                label3.Text = Convert.ToString(scor) + "%";
                label3.Visible = true;

                if (scor <= 10) pictureBox1.ImageLocation = "P 1.png";
                else if (scor <= 20) pictureBox1.ImageLocation = "P 2.png";
                else if (scor <= 30) pictureBox1.ImageLocation = "P 3.png";
                else if (scor <= 40) pictureBox1.ImageLocation = "P 4.png";
                else if (scor <= 50) pictureBox1.ImageLocation = "P 5.png";
                else if (scor <= 60) pictureBox1.ImageLocation = "P 6.png";
                else if (scor <= 70) pictureBox1.ImageLocation = "P 7.png";
                else if (scor <= 80) pictureBox1.ImageLocation = "P 8.png";
                else if (scor <= 90) pictureBox1.ImageLocation = "P 9.png";
                else pictureBox1.ImageLocation = "P 10.png";
                pictureBox1.Visible = true;

                if (scor <= 30) label4.Text = "Relația dintre tine si iepurașul tău nu prea funcționează. Încearcă să identifici problemele dintre voi și să le rezolvi.";
                else if (scor <= 60) label4.Text = "Relația dintre tine și iepurașul tău este una bună, dar nu uita că mereu este loc de mai bine.";
                else label4.Text = "Felicitari! Relația dintre tine și iepurașul tău este una foarte bună. Țineți-o tot așa!";
                label4.Visible = true;
            }

            else Close();
        }
    }
}
