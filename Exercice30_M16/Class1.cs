using System;
using System.Collections.Generic;
using System.Text;
using Exercice27_Agent;

namespace Exercice30_M16
{
    internal class Agence
    {
        public string NomAgence { get; set; }

        List<Agent> Agents;

        public Agence(string nom)
        {
            NomAgence = nom;
            Agents = new List<Agent>();
        }
        public void AfficherAgence()
        {
            Console.WriteLine($"Chez {NomAgence} nous avons {Agents.Count} agents");

        }

        public void IntroduireTousLesAgents()
        {
            foreach (Agent agent in Agents)
            { agent.Introduction(); }
        }

        public void AjouterAgent(Agent agent)
        {
            Agents.Add(agent);
        }
    }
    
    
           
}
