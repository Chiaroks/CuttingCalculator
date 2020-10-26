using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace inst
{
    class MillingCoef
    {
        public ObservableCollection<Operation> OperationList { get; set; }
        private Operation MillingPlanes = new Operation
            (
            "Фрезерование плоскостей",
            new Instrument
            (
                "Торцовые",
                new Mark
                (
                    "T15K6",
                    0,
                    0,
                    0,
                    332,
                    0.2,
                    0.1,
                    0.4,
                    0.2,
                    0,
                    0.2
                ),
                new Mark
                (
                    "P6M5",
                    0,
                    0,
                    0.1,
                    64.7,
                    0.25,
                    0.1,
                    0.2,
                    0.15,
                    0,
                    0.2
                )),
                new Instrument
                (
                "Цилендрические",
                new Mark
                    (
                     "Т15К6",
                     35,
                     2,
                     0,
                     700,
                     0.17,
                     0.38,
                     0.28,
                     0.08,
                     0.1,
                     0.33
                    ),
                 new Mark
                    (
                    "P6M5",
                    0,
                    0,
                    0.1,
                    35.4,
                    0.45,
                    0.3,
                    0.4,
                    0.1,
                    0.1,
                    0.33
                    )
                )

             
            );
        public Operation PloskostIUstup = new Operation
            (
            "фрезерование плоскостей и уступов",
            new Instrument
            (
            "Дисковые со вставными ножами",
                new Mark
                (
                    "Т15К6",
                    0,
                    0,
                    0.12,
                    1340,
                    0.2,
                    0.4,
                    0.12,
                    0,
                    0,
                    0.35
                )
            )
            );
        public Operation Pazi = new Operation
            (
            "Фрезерование пазов",
            new Instrument
            (
                "Дисковые со вставными ножами",
                new Mark
                (
                    "Т15К6",
                    0,
                    0,
                    0.06,
                    1825,
                    0.2,
                    0.3,
                    0.12,
                    0.1,
                    0,
                    0.35
                )
            )
            );
        public Operation PloskosteUstupovPazov = new Operation
            (
            "Фезерование плоскостей уступов и пазов",
            new Instrument
            (
                "Дисковые со вставными ножами",
                new Mark
                (
                    "Р6М5",
                    0,
                    0,
                    0.1,
                    75.5,
                    0.25,
                    0.3,
                    0.2,
                    0.1,
                    0.1,
                    0.2
                )
            ),
            new Instrument
            (
                "Дисковые цельные",
                new Mark
                (
                    "Р6М5",
                    0,
                    0,
                    0,
                    68.5,
                    0.25,
                    0.3,
                    0.2,
                    0.1,
                    0.1,
                    0.2
                )
            ),
            new Instrument
            (
                "Концевые с коронками",
                new Mark
                (
                    "Т15К6",
                    0,
                    0,
                    0,
                    145,
                    0.44,
                    0.24,
                    0.26,
                    0.1,
                    0.13,
                    0.37
                )
            ),
            new Instrument
            (
                "Концевые с напаяными пластинами",
                new Mark
                (
                    "Т15К6",
                    0,
                    0,
                    0,
                    234,
                    0.44,
                    0.24,
                    0.26,
                    0.1,
                    0.13,
                    0.37
                )
            ),
            new Instrument
            (
                "Концевые цельные",
                new Mark
                (
                    "Р6М5",
                    0,
                    0,
                    0,
                    46.7,
                    0.45,
                    0.5,
                    0.5,
                    0.1,
                    0.1,
                    0.33
                )
            )
            );

    }
}
