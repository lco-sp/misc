//Contact @lco-sp via GitHub with any questions

using System;

public class DreamDistribution
{
	const double SIGMA = 1.6; //Standard deviation, how flat the curve is. Should not be modified at runtime, decides how all probabilities are spread. Currently balanced so that 'Neutral' dreams have a probability of ~25% at pawn mood =50%
	public static double NormalDistr(double var_x, double var_mu) //var_x = What type of dream, intended range -5 to +5; var_mu = 'Mean', dependent on pawn mood, suggested range -1 to +1 where 0 == Mood 50%
	{
		double distribution = (Math.Exp(-Math.Pow((var_x-var_mu), 2)/(2*Math.Pow(SIGMA, 2)))/((Math.Sqrt(2*Math.PI))*SIGMA)); //Calculates normal distribution under given parameters
		return (distribution - 0.01); //Subtracts 1% from all results, so that most extreme dreams cannot occur at pawn mood =50%
	}
}
