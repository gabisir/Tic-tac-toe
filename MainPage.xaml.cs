namespace Tic_tac_toe;

public partial class MainPage : ContentPage
{
	int count = 0;//0->x  1->y
	int playfield = 0;//racunamo u mainu u kojoj se sekciji nalazi kliknut gumb od 1 do 9  !!!!!   OVO JE MOZDA NEPOTREBNO  !!!!!
	int playfield_required = 0; // definiramo di ce igrac morat igrat isto od 1 do 9 ali ako moze svugdje onda je 0
    int[] array = new int[] {0, 0, 0, 0, 0, 0, 0, 0, 0}; //nerjeseno 3, x je pobjedio 2, o je pobjedio 1, niko jos nije pobjedio 0
    char[,] field = new char[9, 9];
    int illegal = 0;//zastavica koja se stavi na 1 ako je ilegalno
	int prviPut = 1;

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
            default: return null;
        }
    }
    private void SetImageOfWin (int playfield, int pobjedio)
    {
        if (pobjedio == 1)
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
        if (pobjedio == 2)
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
    }
    public MainPage()
	{
		InitializeComponent();
	}
	
	private void EventClickedHandler(object sender, EventArgs e)
	{
		var button = (ImageButton)sender;
		var classId = button.ClassId;
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
		if(playfield_required!=0)
		{
			if (array[playfield_required - 1] == 1)
				playfield_required = 0;
		}
        
        if (playfield != playfield_required  && prviPut == 0)
		{
            illegal = 1;
			if (playfield_required == 0)
				illegal = 0;
        }
            

        if (illegal==0)
		{
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

		//set image on button
        if (count == 0 && illegal==0)
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
		for (int i = 0; i < 9; i++) 
		{
			for (int j = 0; j < 9; j++)
			{
				//3 provjere po glavnoj dijagonali
				if (i == j && i==0)
					if (field[i, j] == field[i+1,j+1] && field[i, j] == field[i+2,j+2])
					{
						if (field[i, j] == 'x')
							array[0] = 2;
						else if (field[i, j] == 'o')
                            array[0] = 1;
                    }
                if (i == j && i == 3)
                    if (field[i, j] == field[i + 1, j + 1] && field[i, j] == field[i + 2, j + 2])
                    {
                        if (field[i, j] == 'x')
                            array[4] = 2;
                        else if (field[i, j] == 'o')
                            array[4] = 1;
                    }
                if (i == j && i == 6)
                    if (field[i, j] == field[i + 1, j + 1] && field[i, j] == field[i + 2, j + 2])
                    {
                        if (field[i, j] == 'x')
                            array[8] = 2;
                        else if (field[i, j] == 'o')
                            array[8] = 1;
                    }
				//3 provjere za sporednu dijagonalu ovaj put u jednom ifu
				if(i+j==8)
				{
					if(i==1)
					{
                        if (field[i, j] == field[i - 1, j + 1] && field[i, j] == field[i + 1, j - 1])
                        {
                            if (field[i, j] == 'x')
                                array[6] = 2;
                            else if (field[i, j] == 'o')
                                array[6] = 1;
                        }
                    }
                    if (i == 4)
                    {
                        if (field[i, j] == field[i - 1, j + 1] && field[i, j] == field[i + 1, j - 1])
                        {
                            if (field[i, j] == 'x')
                                array[4] = 2;
                            else if (field[i, j] == 'o')
                                array[4] = 1;
                        }
                    }
                    if (i == 7)
                    {
                        if (field[i, j] == field[i - 1, j + 1] && field[i, j] == field[i + 1, j - 1])
                        {
                            if (field[i, j] == 'x')
                                array[2] = 2;
                            else if (field[i, j] == 'o')
                                array[2] = 1;
                        }
                    }
                }
				//ostale dijagonale:
                //to je bezveze if samo da ne provjerava sve te stalo jer ih treba samo jednom, a ostaje u petlji zbog preglednosti
                if(i==j && i==8)
                {
                    if (field[0, 2] == field[1, 1] && field[1, 1] == field[2, 0])
                    {
                        if (field[0, 2] == 'x')
                            array[0] = 2;
                        else if (field[0, 2] == 'o')
                            array[0] = 1;
                    }
                    if (field[6, 8] == field[7, 7] && field[7, 7] == field[8, 6])
                    {
                        if (field[6, 8] == 'x')
                            array[8] = 2;
                        else if (field[6, 8] == 'o')
                            array[8] = 1;
                    }
                    if (field[6, 0] == field[7, 1] && field[7, 1] == field[8, 2])
                    {
                        if (field[6, 0] == 'x')
                            array[2] = 2;
                        else if (field[6, 0] == 'o')
                            array[2] = 1;
                    }
                    if (field[0, 6] == field[1, 7] && field[1, 7] == field[2, 8])
                    {
                        if (field[0, 6] == 'x')
                            array[6] = 2;
                        else if (field[0, 6] == 'o')
                            array[6] = 1;
                    }
                    if (field[3, 0] == field[4, 1] && field[4, 1]== field[5, 2])
                    {
                        if (field[3, 0]=='x')
                            array[1] = 2;
                        else if (field[3, 0] == 'o')
                            array[1] = 1;
                    }
                    if (field[3, 2] == field[4, 1] && field[4, 1] == field[5, 0])
                    {
                        if (field[3, 2] == 'x')
                            array[1] = 2;
                        else if (field[3, 2] == 'o')
                            array[1] = 1;
                    }
                    if (field[0, 3] == field[1, 4] && field[1, 4] == field[2, 5])
                    {
                        if (field[0, 3] == 'x')
                            array[3] = 2;
                        else if (field[0, 3] == 'o')
                            array[3] = 1;
                    }
                    if (field[2, 3] == field[1, 4] && field[1, 4] == field[0, 5])
                    {
                        if (field[2, 3] == 'x')
                            array[3] = 2;
                        else if (field[2, 3] == 'o')
                            array[3] = 1;
                    }
                    if (field[3, 6] == field[4, 7] && field[4, 7] == field[5, 8])
                    {
                        if (field[3, 6] == 'x')
                            array[7] = 2;
                        else if (field[3, 6] == 'o')
                            array[7] = 1;
                    }
                    if (field[5, 6] == field[4, 7] && field[4, 7] == field[3, 8])
                    {
                        if (field[5, 6] == 'x')
                            array[7] = 2;
                        else if (field[5, 6] == 'o')
                            array[7] = 1;
                    }
                    if (field[6, 3] == field[7, 4] && field[7, 4] == field[8, 5])
                    {
                        if (field[6, 3] == 'x')
                            array[5] = 2;
                        else if (field[6, 3] == 'o')
                            array[5] = 1;
                    }
                    if (field[6, 5] == field[7, 4] && field[7, 4] == field[8, 3])
                    {
                        if (field[6, 5] == 'x')
                            array[5] = 2;
                        else if (field[6, 5] == 'o')
                            array[5] = 1;
                    }
                }
				


            }
		}
		


		if(illegal == 1)
		{
            DisplayAlert("Alert", "playfield required= " + playfield_required, "OK");
        }
		illegal = 0;
		if (prviPut == 1) prviPut = 0;
    }
}