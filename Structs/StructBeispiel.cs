using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    /*
     * Normale Klassen können viel overhead (Müll) produzieren zB. durch Vererbung, default-Konstruktor und noch mehr,
     * Selbst wenn diese Eigenschaften nicht genutzt werden sind sie bei einer angelegten Klasse vorhanden,
     * und werden somit zur Laufzeit "durchlaufen", was die Klassen im Allgemeinen langsamer macht!
     * 
     * Wenn diese Fähigkeiten nicht benötigt werden kann ein struct verwendet werden,
     * um unnötige Arbeit zur Laufzeit zu ersparen.
     * 
     * WICHTIG!!
     * class = pointer/referenz-Type, => verweist auf einen Speicherplatz wo ein expliziter Wert gelagert ist
     * struct = value-Type => ist der Wert selbst und gilt somit als IMMUTABLE/UNVERÄNDERLICH!!!
     **/

    struct StructBeispiel
    {
        // Schlechtes Design eines Struct:
        // KEINE SETTER DA IMMUTABLE

        // public string Name { get; set; }
        // public ushort Alter { get; set; }



        // Richtiges Design eines Struct:
        private readonly string name;
        private readonly ushort alter;

        public StructBeispiel(string name, ushort alter)
        {
            this.name = name;
            this.alter = alter;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public int Alter
        {
            get
            {
                return this.alter;
            }
        }

        public override string ToString() => string.Format("Hi, ich bin {0}.\nIch bin {1} Jahre alt.", Name, Alter);
    }
}
