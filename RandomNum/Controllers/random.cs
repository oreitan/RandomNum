using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace randomNum.Controllers
{
    [Route("api/[controller]")]
    public class random : Controller
    {
        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        // GET api/calculator/GetFiveRandomNumbers
        [HttpGet("GetFiveRandomNumbers")]
        public List<int> GetFiveRandomNumbers()
        {
            var numbers = new List<int>();
            var rnd = new Random();
            int count = 0;

            while (count < 5)
            {
                int newNum = rnd.Next(1, 21); // generate a random number between 1- 20

                if (!numbers.Contains(newNum))
                {
                    numbers.Add(newNum);
                    count++;
                }
            }

            return numbers;
        }

        [HttpGet("numSperder")]
        public List<int> Q14(int number)
        {
            int theNumber = number;
            var numbers = new List<int>();
            int fector = 10000;
            if (theNumber > 1000)
            {
                while (fector > 1)
                {
                    fector /= 10;
                    numbers.Add(theNumber / fector);
                    theNumber %= fector;
                }
            }
            return numbers;
        }

        [HttpGet("autiCalc")]
        public object[] Q13(List<int> numbers)
        {
            int c = numbers.Count;
            var res = new object[3];
            if (c == 2)
            {
                int firstNum = numbers[0];
                int secondNum = numbers[1];

                if (secondNum != 0 && firstNum != 0)
                {
                    res[0]=(firstNum / secondNum);

                }
                else if (secondNum == 0)
                {
                    res[0]=(secondNum / firstNum);
                }
                else if (firstNum == 0)
                {
                    res[0]=(firstNum / secondNum);
                }
                else if (firstNum == 0 && secondNum == 0)
                {
                    res[0] = "inf"; 
                }
                res[1]=(firstNum + secondNum);
                res[2]=(firstNum - secondNum);
                res[3]=(firstNum * secondNum);
            }

            return res;
        }


        [HttpGet("revNum")]
        public List<int> Q19(int start)
        {
            var res = new List<int>();
            int num = start;
            num = --num;
            if (num >0)
            {
                while(num > 0)
                {
                    res.Add(num);
                    --num;
                }
                return res;
            }
            else
            {

                res.Add(-1);
                return res;
            }

        }

        [HttpGet("wordRev")]
        public string Q11(string theword="")
        {
            string word = theword;

            if (word.Length > 0)
            {
                char[] wordarray = word.ToCharArray();
                Array.Reverse(wordarray);
                string res = new string(wordarray);
                return res;
            }



            return "error";
        }

        [HttpGet("starNum")]
        public List<string> Q20(int starnum)
        {
            string star = "*";
            int num = starnum;
            var res = new List<string>();

            while (num > 0)
            {
                res.Add(star);
            }
            return res;

        }

    }





}
