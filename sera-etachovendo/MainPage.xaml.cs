﻿namespace sera_etachovendo;

public partial class MainPage : ContentPage
{	
	Results resultado;
	public MainPage()
	{
		InitializeComponent();

		TestarLayout();
		PrencherTela();
	}
	

//------------------------------------------------------------------------------------------------------------------------------------------------------\\
	
	void PrencherTela()
	{
		LabelTemperatura.Text = resultado.temp.ToString();
		LabelCity.Text = resultado.city;
		LabelChuva.Text = resultado.description;
		LabelHumidade.Text = resultado.cloudiness.ToString();
		LabelAmanhecer.Text = resultado.sunrise.ToString();
		LabelAnoitecer.Text = resultado.sunset.ToString();
		LabelForça.Text = resultado.wind_soeedy.ToString();
		LabelDireção.Text = resultado.wind_direction.ToString();
		LabelFase.Text = resultado.moon_phase;


		if (resultado.currently == "dia")
		{
			if (resultado.rain >= 10)
			{
				imgFundo.Source = "chuvadia.jpg";
			}
			else if(resultado.cloudiness >= 10)
			{
				imgFundo.Source = "nubladodia.jpg";
			}
			else
			{
				imgFundo.Source = "ensolarado.jpg";
			}
		}
		else
		{
			if (resultado.rain >= 10)
			{
				imgFundo.Source = "chuvanoite.jpg";
			}
			else if (resultado.cloudiness >= 10)
			{
				imgFundo.Source = "noitenubladdad.jpg";
			}
			else
			{
				imgFundo.Source = "noite.jpg";
			}
		}

	}

//------------------------------------------------------------------------------------------------------------------------------------------------------\\
	void TestarLayout()
	{
		resultado = new Results();

		resultado.temp = 20;
		resultado.city = "PR, Apucarana";
		resultado.description = "Chuva";
		resultado.currently = "noite";
		resultado.rain = 9;	
		resultado.cloudiness = 10;	
		resultado.sunrise = 10;
	}
	
}

