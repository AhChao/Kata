playerOneScore = 0;
playerTwoScore = 0;

function Score()
{
	var dict = ["Love","Fifteen","Thirty","Forty"];
	if(playerOneScore == playerTwoScore)
	{
		if(playerOneScore>=3) return "Deuce";
		return dict[playerOneScore] + " All";
	}
	else
	{
		if(playerOneScore < 4 && playerTwoScore < 4)
		{
			return dict[playerOneScore] + " " + dict[playerTwoScore];
		}
		else
		{
			if(Math.abs(playerOneScore-playerTwoScore) < 2)
			{
				if(playerOneScore>playerTwoScore)
				{
					return "PlayerA Adv";
				}
				else
				{
					return "Player2 Adv";
				}
			}
			else
			{
				if(playerOneScore>playerTwoScore)
				{
					return "PlayerA Won";
				}
				else
				{
					return "Player2 Won";
				}

			}			
		}
	}	
}

function FirstPlayerScore()
{
	if(!isMatchEnd()) playerOneScore++;
	updateview();
}

function SecondPlayerScore()
{
	if(!isMatchEnd()) playerTwoScore++;
	updateview();
}

function isMatchEnd()
{
	if(playerOneScore >= 4 && playerOneScore - playerTwoScore >= 2) return true;
	if(playerTwoScore >= 4 && playerTwoScore - playerOneScore >= 2) return true;
	return false;
}

function ResetScore()
{
	playerOneScore=0;
	playerTwoScore=0;
	updateview();
}

function updateview()
{
	console.log(444);
	document.getElementById('playerOneScore').innerHTML = playerOneScore;
	document.getElementById('playerTwoScore').innerHTML = playerTwoScore;
	document.getElementById('matchResult').innerHTML = Score();
}