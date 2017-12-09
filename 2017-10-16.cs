/**
Below is the question. Solution is from the thread, and it is held here for future study.
https://www.reddit.com/r/dailyprogrammer/comments/76qk58/20171016_challenge_336_easy_cannibal_numbers/
JS version to try: https://www.reddit.com/r/dailyprogrammer/comments/76qk58/20171016_challenge_336_easy_cannibal_numbers/doh79pg/
*/

public static int Cannibals(List<int>numbers, int number)
        {
            var count = numbers.Count(x => x >= number);
            var list = numbers.Where(x => x < number).OrderByDescending(x=>x).Select(x=>new int?(x)).ToList();
            for (int i = 0; i < list.Count; i++)
            {
                var tempNumber = list[i];
                for (int j = list.Count-1; j >=0; j--)
                {
                    if (i==j)
                        continue;
                    if (tempNumber>list[j])
                    {
                        tempNumber++;
                        list[j] = null;
                        if (tempNumber==number)
                        {
                            count++;
                            break;
                        }
                    }
                }
            }
            return count;
        }
