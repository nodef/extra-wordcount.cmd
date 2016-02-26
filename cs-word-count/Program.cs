// required modules
using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.RegularExpressions;


// data types
using StringMap = System.Collections.Generic.Dictionary<string, string>;
using IntMap = System.Collections.Generic.Dictionary<string, int>;

namespace cs_word_count
{
	class Program {
		// main function
		static void Main(string[] args) {
			IntMap count = new IntMap();
			StringMap argm = GetArgs(args);
			try {
				StreamReader file = new StreamReader(argm[""]);
				Regex find = new Regex(argm.ContainsKey("-p") ? argm["-p"] : @"\w+");
				CountInFile(count, find, file);
				ListCounts(count);
			}
			catch (Exception) { Console.WriteLine("word-count [-p <regex pattern>] <source file>"); }
		}

		// display word counts
		static void ListCounts(IntMap count) {
			List<KeyValuePair<string, int>> o = count.ToList();
			o.Sort((a, b) => b.Value.CompareTo(a.Value));
			for (int i = 0; i < o.Count; i++)
				Console.WriteLine(o[i].Key + new string(' ', o[i].Key.Length >= 80 ? 80 : 80 - o[i].Key.Length) + o[i].Value);
			Console.WriteLine();
		}

		// update word counts from a file
		static void CountInFile(IntMap count, Regex find, StreamReader file) {
			string line;
			while ((line = file.ReadLine()) != null)
				CountInLine(count, find, line);
		}

		// update word counts from a line
		static void CountInLine(IntMap count, Regex find, string line) {
			foreach (Match word in find.Matches(line))
				count[word.Value] = count.ContainsKey(word.Value)? count[word.Value]+1 : 1;
		}

		// get arguments to program
		static StringMap GetArgs(string[] args) {
			StringMap o = new StringMap();
			string opt = "";
			for (int i = 0; i < args.Length; i++) {
				if (!args[i].StartsWith("-")) { o[opt] = args[i]; opt = ""; continue; }
				if (opt != "") o[opt] = "";
				opt = args[i];
			}
			return o;
		}
	}
}
