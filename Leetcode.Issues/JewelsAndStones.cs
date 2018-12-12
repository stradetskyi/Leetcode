using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Issues
{
    /// <summary>
    /// https://leetcode.com/problems/jewels-and-stones/
    /// </summary>
    public class JewelsAndStones
    {
	    public int NumJewelsInStones(string J, string S)
	    {
		    int count = 0;

		    for (int i = 0; i < S.Length; i++)
		    {
			    for (int j = 0; j < J.Length; j++)
			    {
				    if (S[i] == J[j])
				    {
					    count++;
					    break;
				    }
			    }
		    }

		    return count;
	    }
    }
}
