using System;

namespace Sumator
{
	public partial class Sumator : System.Web.UI.Page
	{
		protected void Spiral_Click(object sender, EventArgs e)
		{
            decimal firstNum = decimal.Parse(this.TextBoxFirstNum.Text);
            decimal secondNum = decimal.Parse(this.TextBoxSecondNum.Text);

            
            int x = (int)firstNum;
            Response.Write("x = " + x + "<br/>");
            int y = (int)secondNum;
            Response.Write("y = " + y + "<br/>");
                 Response.Write("<br />");
                  int[,] arrInt = new int[y, x];

                  /* Generate matrix [x,y] */

                  for (int a = 0; a < y; a++)
                  {
                      for (int b = 0; b < x; b++)
                      {
                          arrInt[a, b] = x * a + b + 1;
                      }
                  }
                  ///* Print matrix [x,y] */

                  for (int a = 0; a < y; a++)
                  {
                      for (int b = 0; b < x; b++)
                      {
                          Response.Write(arrInt[a, b] + " ");
                      }
                      Response.Write("<br/>");
                  }

                  Response.Write("<br/>");

                  ///* Print matrix in spiral form */

                  byte direction = 0; /*0-right, 1-down, 2-left, 3-right*/
                  int row = 0, col = 0;
                  int matrixIndex = 0;

                  for (int k = 0; k < y; k++)
                  {
                      for (int c = 0; c < x; c++)
                      {

                          Response.Write(arrInt[row, col] + " ");
                          if (direction == 0) //right
                          {
                              if (col + 1 + matrixIndex >= x)
                              {
                                  direction = 1;
                                  row++;
                              }
                              else
                              {
                                  col++;
                              }
                          }
                          else if (direction == 1) //down
                          {
                              if (row + 1 + matrixIndex >= y)
                              {
                                  direction = 2;
                                  col--;
                              }
                              else
                              {
                                  row++;
                              }
                          }
                          else if (direction == 2) //left
                          {
                              if (col - 1 - matrixIndex < 0)
                              {
                                  direction = 3;
                                  row--;
                              }
                              else
                              {
                                  col--;
                              }
                          }
                          else if (direction == 3) //up
                          {
                              if (matrixIndex + 1 == row)
                              {
                                  matrixIndex++;
                              }
                              if (row - 1 - matrixIndex < 0)
                              {
                                  direction = 0;
                                  col++;
                              }
                              else
                              {
                                  row--;
                              }
                          }
                      }
                  }
                  Response.Write("<br/>");
                  Response.Write("<br/>");
		}
	}
}