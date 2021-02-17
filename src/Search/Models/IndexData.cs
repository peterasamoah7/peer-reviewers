using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Search.Models
{
    public class Data
    {
        public Data() { }

        /// <summary>
        /// </summary>
        /// <param name="paper"></param>
        /// <param name="fileName"></param>
        /// <param name="reviewer"></param>
        /// <param name="url"></param>
        public Data(string paper, string fileName, string reviewer)
        {
            this.Paper = paper;
            this.FileName = fileName;
            this.Reviewer = reviewer;
        }

        /// <summary>
        /// Name of Research Paper
        /// </summary>
        public string Paper { get; set; }

        /// <summary>
        /// File name in blob
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Reviwer 
        /// </summary>
        public string Reviewer { get; set; }
    }

    public static class Reviewer
    {
        /// <summary>
        /// Mock data index Data
        /// </summary>
        private static List<Data> IndexData = new List<Data>
        {
            new Data("Formal mutation testing for Circus", "ACGS16.pdf", "Reviewer 1"),
            new Data("Static Object Race Detection", "aplas11.pdf", "Reviewer 2"),
            new Data("An Empirical Study into Class Testability", "jss-testability.pdf", "Reviewer 3"),
            new Data("Constructive Linear-Time Temporal Logic: Proof Systems and Kripke Semantics", "cltl-full.pdf", "Reviewer 4"),
            new Data("Exploiting Prolog for Projecting Agent Interaction Protocols", "AnconaBFMT14.pdf", "Reviewer 5"),
            new Data("Using Annotated C++", "A++-C++AtWork.pdf", "Reviewer 6"),
            new Data("On Abstraction Refinement for Program Analyses in Datalog", "pldi14c.pdf", "Reviewer 7"),
            new Data("Optimal Resilient Sorting and Searching in the Presence of Memory Faults", "TCS_Special_Issue_ICALP06.pdf", "Reviewer 8"),
            new Data("Efficient Inference of Partial Types", "jcss94.pdf", "Reviewer 9"),
            new Data("Performance Portability Across Heterogeneous SoCs Using a Generalized Library-Based Approach", "taco2015-fang.pdf", "Reviewer 10"),
            new Data("jStar-eclipse: an IDE for Automated Verification of Java Programs", "ESEC-FSE.11.jstar-eclipse.pdf", "Reviewer 12"),
            new Data("Distributed Places", "tfp2013-tsffd.pdf", "Reviewer 13"),
            new Data("Z-Rays: Divide Arrays and Conquer Speed and Flexibility", "arraylet-pldi-2010.pdf", "Reviewer 14"),
            new Data("What Can the GC Compute Efficiently? A Language for Heap Assertions at GC Time", "gcassert.pdf", "Reviewer 15"),
            new Data("JATO: Native Code Atomicity for Java", "APLAS12.pdf", "Reviewer 16"),
        };

        /// <summary>
        /// Get Reviewer
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public static Data GetReviewer(string file)
        {
            return IndexData.FirstOrDefault(x => x.FileName == file);
        }
    }
}
