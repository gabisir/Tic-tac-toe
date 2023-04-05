//using GameController;

//using GameController;

namespace Tic_tac_toe;

public partial class MainPage : ContentPage
{
	int count = 1;//0->x  1->y
	int playfield = 0;//racunamo u mainu u kojoj se sekciji nalazi kliknut gumb od 1 do 9  !!!!!   OVO JE MOZDA NEPOTREBNO  !!!!!
	int playfield_required = 0; // definiramo di ce igrac morat igrat isto od 1 do 9 ali ako moze svugdje onda je 0
    int[] array = new int[] {0, 0, 0, 0, 0, 0, 0, 0, 0}; //nerjeseno 3, x je pobjedio 2, o je pobjedio 1, niko jos nije pobjedio 0
    int[] array_filled = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    char[,] field = new char[9, 9];
    int illegal = 0;//zastavica koja se stavi na 1 ako je ilegalno
	int prviPut = 1;
    int pobjeda = 0;
    char who;
    ImageButton lastButton = null;

    private Border GetSectionBorder (int playfield)
    {
        switch(playfield) {
            case 0:
                return PrviB;
            case 1:
                return DrugiB;
            case 2:
                return TreciB;
            case 3:
                return CetvrtiB;
            case 4:
                return PetiB;
            case 5:
                return SestiB;
            case 6:
                return SedmiB;
            case 7:
                return OsmiB;
            case 8:
                return DevetiB;
            default: return PrviB;
        }
    }
    private bool IsNotFilled(int playfield)
    {
        switch (playfield)
        {
            case 0:
                if(dada11.Source.ToString() != "File: empty.png" && dada12.Source.ToString() != "File: empty.png" && dada13.Source.ToString() != "File: empty.png" && dada21.Source.ToString() != "File: empty.png" && dada22.Source.ToString() != "File: empty.png" && dada23.Source.ToString() != "File: empty.png" && dada31.Source.ToString() != "File: empty.png" && dada32.Source.ToString() != "File: empty.png" && dada33.Source.ToString() != "File: empty.png") return true;
                break;
            case 1:
                if (dada14.Source.ToString() != "File: empty.png" && dada15.Source.ToString() != "File: empty.png" && dada16.Source.ToString() != "File: empty.png" && dada24.Source.ToString() != "File: empty.png" && dada25.Source.ToString() != "File: empty.png" && dada26.Source.ToString() != "File: empty.png" && dada34.Source.ToString() != "File: empty.png" && dada35.Source.ToString() != "File: empty.png" && dada36.Source.ToString() != "File: empty.png") return true;
                break;
            case 2:
                if (dada17.Source.ToString() != "File: empty.png" && dada18.Source.ToString() != "File: empty.png" && dada19.Source.ToString() != "File: empty.png" && dada27.Source.ToString() != "File: empty.png" && dada28.Source.ToString() != "File: empty.png" && dada29.Source.ToString() != "File: empty.png" && dada37.Source.ToString() != "File: empty.png" && dada38.Source.ToString() != "File: empty.png" && dada39.Source.ToString() != "File: empty.png") return true;
                break;
            case 3:
                if (dada41.Source.ToString() != "File: empty.png" && dada42.Source.ToString() != "File: empty.png" && dada43.Source.ToString() != "File: empty.png" && dada51.Source.ToString() != "File: empty.png" && dada52.Source.ToString() != "File: empty.png" && dada53.Source.ToString() != "File: empty.png" && dada61.Source.ToString() != "File: empty.png" && dada62.Source.ToString() != "File: empty.png" && dada63.Source.ToString() != "File: empty.png") return true;
                break;
            case 4:
                if (dada44.Source.ToString() != "File: empty.png" && dada45.Source.ToString() != "File: empty.png" && dada46.Source.ToString() != "File: empty.png" && dada54.Source.ToString() != "File: empty.png" && dada55.Source.ToString() != "File: empty.png" && dada56.Source.ToString() != "File: empty.png" && dada64.Source.ToString() != "File: empty.png" && dada65.Source.ToString() != "File: empty.png" && dada66.Source.ToString() != "File: empty.png") return true;
                break;
            case 5:
                if (dada47.Source.ToString() != "File: empty.png" && dada48.Source.ToString() != "File: empty.png" && dada49.Source.ToString() != "File: empty.png" && dada57.Source.ToString() != "File: empty.png" && dada58.Source.ToString() != "File: empty.png" && dada59.Source.ToString() != "File: empty.png" && dada67.Source.ToString() != "File: empty.png" && dada68.Source.ToString() != "File: empty.png" && dada69.Source.ToString() != "File: empty.png") return true;
                break;
            case 6:
                if (dada71.Source.ToString() != "File: empty.png" && dada72.Source.ToString() != "File: empty.png" && dada73.Source.ToString() != "File: empty.png" && dada81.Source.ToString() != "File: empty.png" && dada82.Source.ToString() != "File: empty.png" && dada83.Source.ToString() != "File: empty.png" && dada91.Source.ToString() != "File: empty.png" && dada92.Source.ToString() != "File: empty.png" && dada93.Source.ToString() != "File: empty.png") return true;
                break;
            case 7:
                if (dada74.Source.ToString() != "File: empty.png" && dada75.Source.ToString() != "File: empty.png" && dada76.Source.ToString() != "File: empty.png" && dada84.Source.ToString() != "File: empty.png" && dada85.Source.ToString() != "File: empty.png" && dada86.Source.ToString() != "File: empty.png" && dada94.Source.ToString() != "File: empty.png" && dada95.Source.ToString() != "File: empty.png" && dada96.Source.ToString() != "File: empty.png") return true;
                break;
            case 8:
                if (dada77.Source.ToString() != "File: empty.png" && dada78.Source.ToString() != "File: empty.png" && dada79.Source.ToString() != "File: empty.png" && dada87.Source.ToString() != "File: empty.png" && dada88.Source.ToString() != "File: empty.png" && dada89.Source.ToString() != "File: empty.png" && dada97.Source.ToString() != "File: empty.png" && dada98.Source.ToString() != "File: empty.png" && dada99.Source.ToString() != "File: empty.png") return true;
                break;
        }
        return false;
    }
    private void SetImageOfWin (int playfield, char pobjedio)
    {
        if (pobjedio == '1')
        { //Kruzic pobjedio
            switch (playfield)
            {
                case 0:
                    Img1.Source = "kruzic.png";
                    break;
                case 1:
                    Img2.Source = "kruzic.png";
                    break;
                case 2:
                    Img3.Source = "kruzic.png";
                    break;
                case 3:
                    Img4.Source = "kruzic.png";
                    break;
                case 4:
                    Img5.Source = "kruzic.png";
                    break;
                case 5:
                    Img6.Source = "kruzic.png";
                    break;
                case 6:
                    Img7.Source = "kruzic.png";
                    break;
                case 7:
                    Img8.Source = "kruzic.png";
                    break;
                case 8:
                    Img9.Source = "kruzic.png";
                    break;
            }
        }
        if (pobjedio == '2')
        { //Krizic pobjedio
            switch (playfield)
            {
                case 0:
                    Img1.Source = "krizic.png";
                    break;
                case 1:
                    Img2.Source = "krizic.png";
                    break;
                case 2:
                    Img3.Source = "krizic.png";
                    break;
                case 3:
                    Img4.Source = "krizic.png";
                    break;
                case 4:
                    Img5.Source = "krizic.png";
                    break;
                case 5:
                    Img6.Source = "krizic.png";
                    break;
                case 6:
                    Img7.Source = "krizic.png";
                    break;
                case 7:
                    Img8.Source = "krizic.png";
                    break;
                case 8:
                    Img9.Source = "krizic.png";
                    break;
            }
        }
        if (pobjedio == '9')
        { //Cisti plocu
            switch (playfield)
            {
                case 0:
                    Img1.Source = "empty.png";
                    break;
                case 1:
                    Img2.Source = "empty.png";
                    break;
                case 2:
                    Img3.Source = "empty.png";
                    break;
                case 3:
                    Img4.Source = "empty.png";
                    break;
                case 4:
                    Img5.Source = "empty.png";
                    break;
                case 5:
                    Img6.Source = "empty.png";
                    break;
                case 6:
                    Img7.Source = "empty.png";
                    break;
                case 7:
                    Img8.Source = "empty.png";
                    break;
                case 8:
                    Img9.Source = "empty.png";
                    break;
            }
        }
    }
    public MainPage()
	{
		InitializeComponent();
	}
    private void Reset_button_clicked(object sender, EventArgs e)
    {
        //here goes reset;
        count = 1;
        who = 'f';
        playfield = 0;
        playfield_required = 0;
        pobjeda = 0;
        for (int i = 0; i < 9; i++)
            array[i] = 0;
        for (int i = 0; i < 9; i++)
            for (int j = 0; j < 9; j++)
                field[i, j] = '0';
        illegal = 0;
        prviPut = 1;
        winner.Text = null;
        ImageButton lastButton = null;
        for(int i = 1; i < 10; i++)
        {
            for(int j = 1; j < 10; j++)
            {
                ImageButton tempButt = (ImageButton)FindByName($"dada{i}{j}".ToString());
                if (tempButt != null)
                {
                    tempButt.Source = "empty.png";
                    tempButt.BackgroundColor = Color.FromArgb("#00FFFFFE");
                }
            }
        }
        for(int i = 1; i < 10; i++)
        {
            Image tempButt3 = (Image)FindByName($"Img{i}".ToString());
            Border tempBord = GetSectionBorder(i);
            if (tempBord != null) {
                tempBord.Stroke = Color.FromArgb("FF0000");
                tempBord.StrokeThickness = 1;
                tempBord.Margin = -1;
            }
            if (tempButt3 != null)
            {
                tempButt3.Source = "empty.png";
            }
        }
        
    }

    private void EventClickedHandler(object sender, EventArgs e)
	{
		var button = (ImageButton)sender;
		var classId = button.ClassId;

        
        //biljeske
        /*
         probo sam border na samo jedan gumb, nije islo

         trebo bi poslje treninga stavit array[] da moze bit 4 ako je playfield[] pun, da se moze igrat svudgje, a za to 
         mi treba nekak stanje svih gumbi u playfieldu kaj bi mogo na zgance ali ne zelim ako nije neptorebno (trebam ideju)

         treba onaj regex stavit na ifove u onoj provjeri za win tak da ne promjeni nista nego samo doda provjeru dal je 
         array na tom mjestu vec neko pobjedio da nebi prebriso pobjedu.
        
         osim toga zakomentirano je gore skroz na vrhu " //using GameController; " jer nije htjelo vrtit kod sa tim, a poslje
         se jos i samo generiralo  nakon nekog vremena, to mi je sumljivo

         all in all nije tesko al je zajebano i mislim zavrsit kad se vratim s treninga jedino kaj mi trebas objasnit kak to radi
        od ovog u biljeskama jer meni nije bas sve to jasno
        
         btw reset meni radi kad debuggam ali nisam siguran jel radi bez debbug nacina
        */

        //button.BorderColor = Color.FromArgb("#FF0000FF");

        if (pobjeda == 0)
        {
            // This will give you the value / classId of your button which you'll press
            //DisplayAlert("Alert", $"Zihh si klikno na {button.ClassId}", "OK");
            if (button.Source.ToString() != "File: empty.png") //provjerava jel na gumbu prazna slika ispisivo sam button.source is skonto sve
            {
                illegal = 1;
            }
            if (illegal == 0)
            {
                //provjerava u kojoj se sekciji nalazi kliknut gumb
                if (classId[0] <= '3' && classId[1] <= '3') { playfield = 1; }
                if (classId[0] <= '3' && classId[1] > '3' && classId[1] <= '6') { playfield = 2; }
                if (classId[0] <= '3' && classId[1] > '6' && classId[1] <= '9') { playfield = 3; }
                if (classId[0] > '3' && classId[0] <= '6' && classId[1] <= '3') { playfield = 4; }
                if (classId[0] > '3' && classId[0] <= '6' && classId[1] > '3' && classId[1] <= '6') { playfield = 5; }
                if (classId[0] > '3' && classId[0] <= '6' && classId[1] > '6' && classId[1] <= '9') { playfield = 6; }
                if (classId[0] > '6' && classId[0] <= '9' && classId[1] <= '3') { playfield = 7; }
                if (classId[0] > '6' && classId[0] <= '9' && classId[1] > '3' && classId[1] <= '6') { playfield = 8; }
                if (classId[0] > '6' && classId[0] <= '9' && classId[1] > '6' && classId[1] <= '9') { playfield = 9; }
            }

            
            if (playfield != playfield_required && prviPut == 0)
            {
                illegal = 1;
                if (playfield_required == 0)
                    illegal = 0;
            }
            //illegal = 0;

            if (illegal == 0)
            {
                GetSectionBorder(playfield_required - 1).Stroke = Color.FromArgb("#FF0000");
                GetSectionBorder(playfield_required - 1).StrokeThickness = 1;
                GetSectionBorder(playfield_required - 1).Margin = -1;
                //provjerava u kojoj se sekciji treba igrat iduci potez
                if (classId == "11" || classId == "14" || classId == "17" || classId == "41" || classId == "44" || classId == "47" || classId == "71" || classId == "74" || classId == "77") { playfield_required = 1; }
                if (classId == "12" || classId == "15" || classId == "18" || classId == "42" || classId == "45" || classId == "48" || classId == "72" || classId == "75" || classId == "78") { playfield_required = 2; }
                if (classId == "13" || classId == "16" || classId == "19" || classId == "43" || classId == "46" || classId == "49" || classId == "73" || classId == "76" || classId == "79") { playfield_required = 3; }
                if (classId == "21" || classId == "24" || classId == "27" || classId == "51" || classId == "54" || classId == "57" || classId == "81" || classId == "84" || classId == "87") { playfield_required = 4; }
                if (classId == "22" || classId == "25" || classId == "28" || classId == "52" || classId == "55" || classId == "58" || classId == "82" || classId == "85" || classId == "88") { playfield_required = 5; }
                if (classId == "23" || classId == "26" || classId == "29" || classId == "53" || classId == "56" || classId == "59" || classId == "83" || classId == "86" || classId == "89") { playfield_required = 6; }
                if (classId == "31" || classId == "34" || classId == "37" || classId == "61" || classId == "64" || classId == "67" || classId == "91" || classId == "94" || classId == "97") { playfield_required = 7; }
                if (classId == "32" || classId == "35" || classId == "38" || classId == "62" || classId == "65" || classId == "68" || classId == "92" || classId == "95" || classId == "98") { playfield_required = 8; }
                if (classId == "33" || classId == "36" || classId == "39" || classId == "63" || classId == "66" || classId == "69" || classId == "93" || classId == "96" || classId == "99") { playfield_required = 9; }
            }
            if (IsNotFilled(playfield_required - 1) && playfield != playfield_required && button.Source.ToString() != "File: empty.png") // GLEDAJ OVO, KINDA SUS
            {
                playfield_required = 0;
            }

            //set image on button
            if (count == 0 && illegal == 0)
            {
                count = 1;
                button.Source = "kruzic.png";
                field[(int)Char.GetNumericValue(classId[0]) - 1, (int)Char.GetNumericValue(classId[1]) - 1] = 'o';  //u polje cemo spremit x i o da lakse provjeravamo pobjede
            }
            else if (count == 1 && illegal == 0)
            {
                count = 0;
                button.Source = "krizic.png";
                field[(int)Char.GetNumericValue(classId[0]) - 1, (int)Char.GetNumericValue(classId[1]) - 1] = 'x'; //nacin spremanja u char 2d polje je polje[x,y]=z;
            }
            
            //check for a win
            if(illegal==0)
            {
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        //3 provjere po glavnoj dijagonali
                        if (i == j && i == 0)
                            if (field[i, j] == field[i + 1, j + 1] && field[i, j] == field[i + 2, j + 2])
                            {
                                if (field[i, j] == 'x' && array[0]!=1)
                                    array[0] = 2;
                                else if (field[i, j] == 'o' && array[0]!=2)
                                    array[0] = 1;
                            }
                        if (i == j && i == 3)
                            if (field[i, j] == field[i + 1, j + 1] && field[i, j] == field[i + 2, j + 2])
                            {
                                if (field[i, j] == 'x' && array[4] != 1)
                                    array[4] = 2;
                                else if (field[i, j] == 'o' && array[4] != 2)
                                    array[4] = 1;
                            }
                        if (i == j && i == 6)
                            if (field[i, j] == field[i + 1, j + 1] && field[i, j] == field[i + 2, j + 2])
                            {
                                if (field[i, j] == 'x' && array[8] != 1)
                                    array[8] = 2;
                                else if (field[i, j] == 'o' && array[8] != 2)
                                    array[8] = 1;
                            }
                        //3 provjere za sporednu dijagonalu ovaj put u jednom ifu
                        if (i + j == 8)
                        {
                            if (i == 1)
                            {
                                if (field[i, j] == field[i - 1, j + 1] && field[i, j] == field[i + 1, j - 1])
                                {
                                    if (field[i, j] == 'x' && array[2] != 1)
                                        array[2] = 2;
                                    else if (field[i, j] == 'o' && array[2] != 2)
                                        array[2] = 1;
                                }
                            }
                            if (i == 4)
                            {
                                if (field[i, j] == field[i - 1, j + 1] && field[i, j] == field[i + 1, j - 1])
                                {
                                    if (field[i, j] == 'x' && array[4] != 1)
                                        array[4] = 2;
                                    else if (field[i, j] == 'o' && array[4] != 2)
                                        array[4] = 1;
                                }
                            }
                            if (i == 7)
                            {
                                if (field[i, j] == field[i - 1, j + 1] && field[i, j] == field[i + 1, j - 1])
                                {
                                    if (field[i, j] == 'x' && array[6] != 1)
                                        array[6] = 2;
                                    else if (field[i, j] == 'o' && array[6] != 2)
                                        array[6] = 1;
                                }
                            }
                        }
                        //ostale dijagonale:
                        //to je bezveze if samo da ne provjerava sve te stalo jer ih treba samo jednom, a ostaje u petlji zbog preglednosti
                        if (i == j && i == 8)
                        {
                            if (field[0, 2] == field[1, 1] && field[1, 1] == field[2, 0])
                            {
                                if (field[0, 2] == 'x' && array[0] != 1)
                                    array[0] = 2;
                                else if (field[0, 2] == 'o' && array[0] != 2)
                                    array[0] = 1;
                            }
                            if (field[6, 8] == field[7, 7] && field[7, 7] == field[8, 6])
                            {
                                if (field[6, 8] == 'x' && array[8] != 1)
                                    array[8] = 2;
                                else if (field[6, 8] == 'o' && array[8] != 2)
                                    array[8] = 1;
                            }
                            if (field[6, 0] == field[7, 1] && field[7, 1] == field[8, 2])
                            {
                                if (field[6, 0] == 'x' && array[6] != 1)
                                    array[6] = 2;
                                else if (field[6, 0] == 'o' && array[6] != 2)
                                    array[6] = 1;
                            }
                            if (field[0, 6] == field[1, 7] && field[1, 7] == field[2, 8])
                            {
                                if (field[0, 6] == 'x' && array[2] != 1)
                                    array[2] = 2;
                                else if (field[0, 6] == 'o' && array[2] != 2)
                                    array[2] = 1;
                            }
                            if (field[3, 0] == field[4, 1] && field[4, 1] == field[5, 2])
                            {
                                if (field[3, 0] == 'x' && array[3] != 1)
                                    array[3] = 2;
                                else if (field[3, 0] == 'o' && array[3] != 2)
                                    array[3] = 1;
                            }
                            if (field[0, 3] == field[1, 4] && field[1, 4] == field[2, 5])
                            {
                                if (field[0, 3] == 'x' && array[1] != 1)
                                    array[1] = 2;
                                else if (field[0, 3] == 'o' && array[1] != 2)
                                    array[1] = 1;
                            }
                            if (field[3, 2] == field[4, 1] && field[4, 1] == field[5, 0])
                            {
                                if (field[3, 2] == 'x' && array[3] != 1)
                                    array[3] = 2;
                                else if (field[3, 2] == 'o' && array[3] != 2)
                                    array[3] = 1;
                            }
                            if (field[2, 3] == field[1, 4] && field[1, 4] == field[0, 5])
                            {
                                if (field[2, 3] == 'x' && array[1] != 1)
                                    array[1] = 2;
                                else if (field[2, 3] == 'o' && array[1] != 2)
                                    array[1] = 1;
                            }

                            if (field[5, 6] == field[4, 7] && field[4, 7] == field[3, 8])
                            {
                                if (field[5, 6] == 'x' && array[5] != 1)
                                    array[5] = 2;
                                else if (field[5, 6] == 'o' && array[5] != 2)
                                    array[5] = 1;
                            }
                            if (field[6, 5] == field[7, 4] && field[7, 4] == field[8, 3])
                            {
                                if (field[6, 5] == 'x' && array[7] != 1)
                                    array[7] = 2;
                                else if (field[6, 5] == 'o' && array[7] != 2)
                                    array[7] = 1;
                            }
                            if (field[6, 3] == field[7, 4] && field[7, 4] == field[8, 5])
                            {
                                if (field[6, 3] == 'x' && array[7] != 1)
                                    array[7] = 2;
                                else if (field[6, 3] == 'o' && array[7] != 2)
                                    array[7] = 1;
                            }
                            if (field[3, 6] == field[4, 7] && field[4, 7] == field[5, 8])
                            {
                                if (field[3, 6] == 'x' && array[5] != 1)
                                    array[5] = 2;
                                else if (field[3, 6] == 'o' && array[5] != 2)
                                    array[5] = 1;
                            }

                        }

                        //horizontalne fakat
                        if (i == 0)
                        {
                            if (j == 0)
                            {
                                if (field[i, j] == field[i, j + 1] && field[i, j] == field[i, j + 2])
                                {
                                    if (field[i, j] == 'x' && array[0] != 1)
                                        array[0] = 2;
                                    else if (field[i, j] == 'o' && array[0] != 2)
                                        array[0] = 1;
                                }
                            }
                            if (j == 3)
                            {
                                if (field[i, j] == field[i, j + 1] && field[i, j] == field[i, j + 2])
                                {
                                    if (field[i, j] == 'x' && array[1] != 1)
                                        array[1] = 2;
                                    else if (field[i, j] == 'o' && array[1] != 2)
                                        array[1] = 1;
                                }
                            }
                            if (j == 6)
                            {
                                if (field[i, j] == field[i, j + 1] && field[i, j] == field[i, j + 2])
                                {
                                    if (field[i, j] == 'x' && array[2] != 1)
                                        array[2] = 2;
                                    else if (field[i, j] == 'o' && array[2] != 2)
                                        array[2] = 1;
                                }
                            }
                        }
                        if (i == 1)
                        {
                            if (j == 0)
                            {
                                if (field[i, j] == field[i, j + 1] && field[i, j] == field[i, j + 2])
                                {
                                    if (field[i, j] == 'x' && array[0] != 1)
                                        array[0] = 2;
                                    else if (field[i, j] == 'o' && array[0] != 2)
                                        array[0] = 1;
                                }
                            }
                            if (j == 3)
                            {
                                if (field[i, j] == field[i, j + 1] && field[i, j] == field[i, j + 2])
                                {
                                    if (field[i, j] == 'x' && array[1] != 1)
                                        array[1] = 2;
                                    else if (field[i, j] == 'o' && array[1] != 2)
                                        array[1] = 1;
                                }
                            }
                            if (j == 6)
                            {
                                if (field[i, j] == field[i, j + 1] && field[i, j] == field[i, j + 2])
                                {
                                    if (field[i, j] == 'x' && array[2] != 1)
                                        array[2] = 2;
                                    else if (field[i, j] == 'o' && array[2] != 2)
                                        array[2] = 1;
                                }
                            }
                        }
                        if (i == 2)
                        {
                            if (j == 0)
                            {
                                if (field[i, j] == field[i, j + 1] && field[i, j] == field[i, j + 2])
                                {
                                    if (field[i, j] == 'x' && array[0] != 1)
                                        array[0] = 2;
                                    else if (field[i, j] == 'o' && array[0] != 2)
                                        array[0] = 1;
                                }
                            }
                            if (j == 3)
                            {
                                if (field[i, j] == field[i, j + 1] && field[i, j] == field[i, j + 2])
                                {
                                    if (field[i, j] == 'x' && array[1] != 1)
                                        array[1] = 2;
                                    else if (field[i, j] == 'o' && array[1] != 2)
                                        array[1] = 1;
                                }
                            }
                            if (j == 6)
                            {
                                if (field[i, j] == field[i, j + 1] && field[i, j] == field[i, j + 2])
                                {
                                    if (field[i, j] == 'x' && array[2] != 1)
                                        array[2] = 2;
                                    else if (field[i, j] == 'o' && array[2] != 2)
                                        array[2] = 1;
                                }
                            }
                        }
                        if (i == 3)
                        {
                            if (j == 0)
                            {
                                if (field[i, j] == field[i, j + 1] && field[i, j] == field[i, j + 2])
                                {
                                    if (field[i, j] == 'x' && array[3] != 1)
                                        array[3] = 2;
                                    else if (field[i, j] == 'o' && array[3] != 2)
                                        array[3] = 1;
                                }
                            }
                            if (j == 3)
                            {
                                if (field[i, j] == field[i, j + 1] && field[i, j] == field[i, j + 2])
                                {
                                    if (field[i, j] == 'x' && array[4] != 1)
                                        array[4] = 2;
                                    else if (field[i, j] == 'o' && array[4] != 2)
                                        array[4] = 1;
                                }
                            }
                            if (j == 6)
                            {
                                if (field[i, j] == field[i, j + 1] && field[i, j] == field[i, j + 2])
                                {
                                    if (field[i, j] == 'x' && array[5] != 1)
                                        array[5] = 2;
                                    else if (field[i, j] == 'o' && array[5] != 2)
                                        array[5] = 1;
                                }
                            }
                        }
                        if (i == 4)
                        {
                            if (j == 0)
                            {
                                if (field[i, j] == field[i, j + 1] && field[i, j] == field[i, j + 2])
                                {
                                    if (field[i, j] == 'x' && array[3] != 1)
                                        array[3] = 2;
                                    else if (field[i, j] == 'o' && array[3] != 2)
                                        array[3] = 1;
                                }
                            }
                            if (j == 3)
                            {
                                if (field[i, j] == field[i, j + 1] && field[i, j] == field[i, j + 2])
                                {
                                    if (field[i, j] == 'x' && array[4] != 1)
                                        array[4] = 2;
                                    else if (field[i, j] == 'o' && array[4] != 2)
                                        array[4] = 1;
                                }
                            }
                            if (j == 6)
                            {
                                if (field[i, j] == field[i, j + 1] && field[i, j] == field[i, j + 2])
                                {
                                    if (field[i, j] == 'x' && array[5] != 1)
                                        array[5] = 2;
                                    else if (field[i, j] == 'o' && array[5] != 2)
                                        array[5] = 1;
                                }
                            }
                        }
                        if (i == 5)
                        {
                            if (j == 0)
                            {
                                if (field[i, j] == field[i, j + 1] && field[i, j] == field[i, j + 2])
                                {
                                    if (field[i, j] == 'x' && array[3] != 1)
                                        array[3] = 2;
                                    else if (field[i, j] == 'o' && array[3] != 2)
                                        array[3] = 1;
                                }
                            }
                            if (j == 3)
                            {
                                if (field[i, j] == field[i, j + 1] && field[i, j] == field[i, j + 2])
                                {
                                    if (field[i, j] == 'x' && array[4] != 1)
                                        array[4] = 2;
                                    else if (field[i, j] == 'o' && array[4] != 2)
                                        array[4] = 1;
                                }
                            }
                            if (j == 6)
                            {
                                if (field[i, j] == field[i, j + 1] && field[i, j] == field[i, j + 2])
                                {
                                    if (field[i, j] == 'x' && array[5] != 1)
                                        array[5] = 2;
                                    else if (field[i, j] == 'o' && array[5] != 2)
                                        array[5] = 1;
                                }
                            }
                        }
                        if (i == 6)
                        {
                            if (j == 0)
                            {
                                if (field[i, j] == field[i, j + 1] && field[i, j] == field[i, j + 2])
                                {
                                    if (field[i, j] == 'x' && array[6] != 1)
                                        array[6] = 2;
                                    else if (field[i, j] == 'o' && array[6] != 2)
                                        array[6] = 1;
                                }
                            }
                            if (j == 3)
                            {
                                if (field[i, j] == field[i, j + 1] && field[i, j] == field[i, j + 2])
                                {
                                    if (field[i, j] == 'x' && array[7] != 1)
                                        array[7] = 2;
                                    else if (field[i, j] == 'o' && array[7] != 2)
                                        array[7] = 1;
                                }
                            }
                            if (j == 6)
                            {
                                if (field[i, j] == field[i, j + 1] && field[i, j] == field[i, j + 2])
                                {
                                    if (field[i, j] == 'x' && array[8] != 1)
                                        array[8] = 2;
                                    else if (field[i, j] == 'o' && array[8] != 2)
                                        array[8] = 1;
                                }
                            }
                        }
                        if (i == 7)
                        {
                            if (j == 0)
                            {
                                if (field[i, j] == field[i, j + 1] && field[i, j] == field[i, j + 2])
                                {
                                    if (field[i, j] == 'x' && array[6] != 1)
                                        array[6] = 2;
                                    else if (field[i, j] == 'o' && array[6] != 2)
                                        array[6] = 1;
                                }
                            }
                            if (j == 3)
                            {
                                if (field[i, j] == field[i, j + 1] && field[i, j] == field[i, j + 2])
                                {
                                    if (field[i, j] == 'x' && array[7] != 1)
                                        array[7] = 2;
                                    else if (field[i, j] == 'o' && array[7] != 2)
                                        array[7] = 1;
                                }
                            }
                            if (j == 6)
                            {
                                if (field[i, j] == field[i, j + 1] && field[i, j] == field[i, j + 2])
                                {
                                    if (field[i, j] == 'x' && array[8] != 1)
                                        array[8] = 2;
                                    else if (field[i, j] == 'o' && array[8] != 2)
                                        array[8] = 1;
                                }
                            }
                        }
                        if (i == 8)
                        {
                            if (j == 0)
                            {
                                if (field[i, j] == field[i, j + 1] && field[i, j] == field[i, j + 2])
                                {
                                    if (field[i, j] == 'x' && array[6] != 1)
                                        array[6] = 2;
                                    else if (field[i, j] == 'o' && array[6] != 2)
                                        array[6] = 1;
                                }
                            }
                            if (j == 3)
                            {
                                if (field[i, j] == field[i, j + 1] && field[i, j] == field[i, j + 2])
                                {
                                    if (field[i, j] == 'x' && array[7] != 1)
                                        array[7] = 2;
                                    else if (field[i, j] == 'o' && array[7] != 2)
                                        array[7] = 1;
                                }
                            }
                            if (j == 6)
                            {
                                if (field[i, j] == field[i, j + 1] && field[i, j] == field[i, j + 2])
                                {
                                    if (field[i, j] == 'x' && array[8] != 1)
                                        array[8] = 2;
                                    else if (field[i, j] == 'o' && array[8] != 2)
                                        array[8] = 1;
                                }
                            }
                        }
                        //vertikalne 
                        if (j == 0)
                        {
                            if (i == 0)
                            {
                                if (field[i, j] == field[i + 1, j] && field[i, j] == field[i + 2, j])
                                {
                                    if (field[i, j] == 'x' && array[0] != 1)
                                        array[0] = 2;
                                    else if (field[i, j] == 'o' && array[0] != 2)
                                        array[0] = 1;
                                }
                            }
                            if (i == 3)
                            {
                                if (field[i, j] == field[i + 1, j] && field[i, j] == field[i + 2, j])
                                {
                                    if (field[i, j] == 'x' && array[3] != 1)
                                        array[3] = 2;
                                    else if (field[i, j] == 'o' && array[3] != 2)
                                        array[3] = 1;
                                }
                            }
                            if (i == 6)
                            {
                                if (field[i, j] == field[i + 1, j] && field[i, j] == field[i + 2, j])
                                {
                                    if (field[i, j] == 'x' && array[6] != 1)
                                        array[6] = 2;
                                    else if (field[i, j] == 'o' && array[6] != 2)
                                        array[6] = 1;
                                }
                            }
                        }
                        if (j == 1)
                        {
                            if (i == 0)
                            {
                                if (field[i, j] == field[i + 1, j] && field[i, j] == field[i + 2, j])
                                {
                                    if (field[i, j] == 'x' && array[0] != 1)
                                        array[0] = 2;
                                    else if (field[i, j] == 'o' && array[0] != 2)
                                        array[0] = 1;
                                }
                            }
                            if (i == 3)
                            {
                                if (field[i, j] == field[i + 1, j] && field[i, j] == field[i + 2, j])
                                {
                                    if (field[i, j] == 'x' && array[3] != 1)
                                        array[3] = 2;
                                    else if (field[i, j] == 'o' && array[3] != 2)
                                        array[3] = 1;
                                }
                            }
                            if (i == 6)
                            {
                                if (field[i, j] == field[i + 1, j] && field[i, j] == field[i + 2, j])
                                {
                                    if (field[i, j] == 'x' && array[6] != 1)
                                        array[6] = 2;
                                    else if (field[i, j] == 'o' && array[6] != 2)
                                        array[6] = 1;
                                }
                            }
                        }
                        if (j == 2)
                        {
                            if (i == 0)
                            {
                                if (field[i, j] == field[i + 1, j] && field[i, j] == field[i + 2, j])
                                {
                                    if (field[i, j] == 'x' && array[0] != 1)
                                        array[0] = 2;
                                    else if (field[i, j] == 'o' && array[0] != 2)
                                        array[0] = 1;
                                }
                            }
                            if (i == 3)
                            {
                                if (field[i, j] == field[i + 1, j] && field[i, j] == field[i + 2, j])
                                {
                                    if (field[i, j] == 'x' && array[3] != 1)
                                        array[3] = 2;
                                    else if (field[i, j] == 'o' && array[3] != 2)
                                        array[3] = 1;
                                }
                            }
                            if (i == 6)
                            {
                                if (field[i, j] == field[i + 1, j] && field[i, j] == field[i + 2, j])
                                {
                                    if (field[i, j] == 'x' && array[6] != 1)
                                        array[6] = 2;
                                    else if (field[i, j] == 'o' && array[6] != 2)
                                        array[6] = 1;
                                }
                            }
                        }
                        if (j == 3)
                        {
                            if (i == 0)
                            {
                                if (field[i, j] == field[i + 1, j] && field[i, j] == field[i + 2, j])
                                {
                                    if (field[i, j] == 'x' && array[1] != 1)
                                        array[1] = 2;
                                    else if (field[i, j] == 'o' && array[1] != 2)
                                        array[1] = 1;
                                }
                            }
                            if (i == 3)
                            {
                                if (field[i, j] == field[i + 1, j] && field[i, j] == field[i + 2, j])
                                {
                                    if (field[i, j] == 'x' && array[4] != 1)
                                        array[4] = 2;
                                    else if (field[i, j] == 'o' && array[4] != 2)
                                        array[4] = 1;
                                }
                            }
                            if (i == 6)
                            {
                                if (field[i, j] == field[i + 1, j] && field[i, j] == field[i + 2, j])
                                {
                                    if (field[i, j] == 'x' && array[7] != 1)
                                        array[7] = 2;
                                    else if (field[i, j] == 'o' && array[7] != 2)
                                        array[7] = 1;
                                }
                            }
                        }
                        if (j == 4)
                        {
                            if (i == 0)
                            {
                                if (field[i, j] == field[i + 1, j] && field[i, j] == field[i + 2, j])
                                {
                                    if (field[i, j] == 'x' && array[1] != 1)
                                        array[1] = 2;
                                    else if (field[i, j] == 'o' && array[1] != 2)
                                        array[1] = 1;
                                }
                            }
                            if (i == 3)
                            {
                                if (field[i, j] == field[i + 1, j] && field[i, j] == field[i + 2, j])
                                {
                                    if (field[i, j] == 'x' && array[4] != 1)
                                        array[4] = 2;
                                    else if (field[i, j] == 'o' && array[4] != 2)
                                        array[4] = 1;
                                }
                            }
                            if (i == 6)
                            {
                                if (field[i, j] == field[i + 1, j] && field[i, j] == field[i + 2, j])
                                {
                                    if (field[i, j] == 'x' && array[7] != 1)
                                        array[7] = 2;
                                    else if (field[i, j] == 'o' && array[7] != 2)
                                        array[7] = 1;
                                }
                            }
                        }
                        if (j == 5)
                        {
                            if (i == 0)
                            {
                                if (field[i, j] == field[i + 1, j] && field[i, j] == field[i + 2, j])
                                {
                                    if (field[i, j] == 'x' && array[1] != 1)
                                        array[1] = 2;
                                    else if (field[i, j] == 'o' && array[1] != 2)
                                        array[1] = 1;
                                }
                            }
                            if (i == 3)
                            {
                                if (field[i, j] == field[i + 1, j] && field[i, j] == field[i + 2, j])
                                {
                                    if (field[i, j] == 'x' && array[4] != 1)
                                        array[4] = 2;
                                    else if (field[i, j] == 'o' && array[4] != 2)
                                        array[4] = 1;
                                }
                            }
                            if (i == 6)
                            {
                                if (field[i, j] == field[i + 1, j] && field[i, j] == field[i + 2, j])
                                {
                                    if (field[i, j] == 'x' && array[7] != 1)
                                        array[7] = 2;
                                    else if (field[i, j] == 'o' && array[7] != 2)
                                        array[7] = 1;
                                }
                            }
                        }
                        if (j == 6)
                        {
                            if (i == 0)
                            {
                                if (field[i, j] == field[i + 1, j] && field[i, j] == field[i + 2, j])
                                {
                                    if (field[i, j] == 'x' && array[2] != 1)
                                        array[2] = 2;
                                    else if (field[i, j] == 'o' && array[2] != 2)
                                        array[2] = 1;
                                }
                            }
                            if (i == 3)
                            {
                                if (field[i, j] == field[i + 1, j] && field[i, j] == field[i + 2, j])
                                {
                                    if (field[i, j] == 'x' && array[5] != 1)
                                        array[5] = 2;
                                    else if (field[i, j] == 'o' && array[5] != 2)
                                        array[5] = 1;
                                }
                            }
                            if (i == 6)
                            {
                                if (field[i, j] == field[i + 1, j] && field[i, j] == field[i + 2, j])
                                {
                                    if (field[i, j] == 'x' && array[8] != 1)
                                        array[8] = 2;
                                    else if (field[i, j] == 'o' && array[8] != 2)
                                        array[8] = 1;
                                }
                            }
                        }
                        if (j == 7)
                        {
                            if (i == 0)
                            {
                                if (field[i, j] == field[i + 1, j] && field[i, j] == field[i + 2, j])
                                {
                                    if (field[i, j] == 'x' && array[2] != 1)
                                        array[2] = 2;
                                    else if (field[i, j] == 'o' && array[2] != 2)
                                        array[2] = 1;
                                }
                            }
                            if (i == 3)
                            {
                                if (field[i, j] == field[i + 1, j] && field[i, j] == field[i + 2, j])
                                {
                                    if (field[i, j] == 'x' && array[5] != 1)
                                        array[5] = 2;
                                    else if (field[i, j] == 'o' && array[5] != 2)
                                        array[5] = 1;
                                }
                            }
                            if (i == 6)
                            {
                                if (field[i, j] == field[i + 1, j] && field[i, j] == field[i + 2, j])
                                {
                                    if (field[i, j] == 'x' && array[8] != 1)
                                        array[8] = 2;
                                    else if (field[i, j] == 'o' && array[8] != 2)
                                        array[8] = 1;
                                }
                            }
                        }
                        if (j == 8)
                        {
                            if (i == 0)
                            {
                                if (field[i, j] == field[i + 1, j] && field[i, j] == field[i + 2, j])
                                {
                                    if (field[i, j] == 'x' && array[2] != 1)
                                        array[2] = 2;
                                    else if (field[i, j] == 'o' && array[2] != 2)
                                        array[2] = 1;
                                }
                            }
                            if (i == 3)
                            {
                                if (field[i, j] == field[i + 1, j] && field[i, j] == field[i + 2, j])
                                {
                                    if (field[i, j] == 'x' && array[5] != 1)
                                        array[5] = 2;
                                    else if (field[i, j] == 'o' && array[5] != 2)
                                        array[5] = 1;
                                }
                            }
                            if (i == 6)
                            {
                                if (field[i, j] == field[i + 1, j] && field[i, j] == field[i + 2, j])
                                {
                                    if (field[i, j] == 'x' && array[8] != 1)
                                        array[8] = 2;
                                    else if (field[i, j] == 'o' && array[8] != 2)
                                        array[8] = 1;
                                }
                            }
                        }
                    }
                }
                for (int i = 0; i < 9; i++)
                {
                    if (array[i] == 1)
                    {
                        SetImageOfWin(i, '1');
                    }
                    else if (array[i] == 2)
                    {
                        SetImageOfWin(i, '2');
                    }
                }
            }
            

            if (illegal == 1)
            {
                //DisplayAlert("Alert", "playfield required= " + playfield_required, "OK");
                GetSectionBorder(playfield_required - 1).Stroke = Color.FromArgb("#0000FF");
                GetSectionBorder(playfield_required - 1).StrokeThickness = 3;
                GetSectionBorder(playfield_required - 1).Margin = -3;
            }

            if(true)
            {
                if (array[0] == array[1] && array[1] == array[2])
                {
                if (array[0] == 1)
                    who = 'o';
                if (array[0] == 2)
                    who = 'x';
                }
                if (array[3] == array[4] && array[4] == array[5])
                {
                    if (array[3] == 1)
                        who = 'o';
                    if (array[3] == 2)
                        who = 'x';
                }
                if (array[6] == array[7] && array[7] == array[8])
                {
                    if (array[6] == 1)
                        who = 'o';
                    if (array[6] == 2)
                        who = 'x';
                }
                if (array[0] == array[3] && array[3] == array[6])
                {
                    if (array[0] == 1)
                        who = 'o';
                    if (array[0] == 2)
                        who = 'x';
                }
                if (array[1] == array[4] && array[4] == array[7])
                {
                    if (array[1] == 1)
                        who = 'o';
                    if (array[1] == 2)
                        who = 'x';
                }
                if (array[2] == array[5] && array[5] == array[8])
                {
                    if (array[2] == 1)
                        who = 'o';
                    if (array[2] == 2)
                        who = 'x';
                }
                if (array[0] == array[4] && array[4] == array[8])
                {
                    if (array[4] == 1)
                        who = 'o';
                    if (array[4] == 2)
                        who = 'x';
                }
                if (array[2] == array[4] && array[4] == array[6])
                {
                    if (array[4] == 1)
                        who = 'o';
                    if (array[4] == 2)
                        who = 'x';
                }
            }

            if (who == 'x')
            {
                winner.Text = "The winner is: X";
                pobjeda = 1;
                reset.IsVisible = true;
            }
                
            if (who == 'o')
            {
                winner.Text = "The winner is: O";
                pobjeda = 1;
                reset.IsVisible = true;
            }
            else if(who!='o' && who!='x')
            {
                winner.Text = " ";
                pobjeda = 0;
                reset.IsVisible = true;
            }
            if (illegal == 0)
            {
                if (lastButton != null) lastButton.BackgroundColor = Color.FromArgb("#00FFFFFE");
                button.BackgroundColor = Color.FromArgb("#4000FFFF");//ovo je neki pokusaj stavljanja bordera -rjeseno
                lastButton = button;
            }
            illegal = 0;
            if (prviPut == 1) prviPut = 0;

            // if(pobjeda) {
            //winner.Text = $"Winner is {who}";
            // }
            if (playfield_required != 0)
            {
                if (array[playfield - 1] != 0)
                {
                    //provjera jel u playfieldu koji je pobjeđen ima praznih mjesta
                    if (IsNotFilled(playfield - 1))
                    {
                        Image tempImg = (Image)FindByName($"Img{playfield}");
                        tempImg.Opacity = 1;
                    }
                }
            }
            
        }
    }
}