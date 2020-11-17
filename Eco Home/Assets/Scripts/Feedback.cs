using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Feedback : ScriptableObject
{
    public Dictionary<int, string> userFeedback = new Dictionary<int, string>{

        [1] = $@"+ Cleaned lint filter before using drying machine\n\n~ Used drying machine\n\n-Used unsustainable detergent\n- Used hot wash cycle\n- Used long wash cycle\n\n
        Nice attempt! To increase your sustainability, we recommend limiting the use of the drying machine and opting for a shorter wash".Replace($@"\n", System.Environment.NewLine),
        
        [2] = $@"~ Used drying machine\n\n- Used unsustainable detergent\n- Didn't clean out lint filter before using drying machine\n- Used hot wash cycle\n- Used long wash\n\n
        Good attempt! We recommend cleaning out your lint filter before using the drying machine. This allows for more efficient heating and drying!".Replace($@"\n", System.Environment.NewLine),
        
        [3] = $@"+ Used clothesline\n\n- Used unsustainable detergent\n- Used hot wash cycle\n- Used long wash\n\n
        Good attempt! We recommend using a cold wash and a shorter cycle to reduce energy consumption!".Replace($@"\n", System.Environment.NewLine),
        
        [4] = $@"+ Used shorter wash cycle\n\n- Used unsustainable detergent\n- Used hot wash cycle\n- Used drying machine to dry clothes\n\n
        Nice attempt! To increase your sustainability, we recommend using a cold wash cycle to reduce your electricity usage".Replace($@"\n", System.Environment.NewLine),

        [5] = $@"+ Used shorter wash cycle\n\n~ Used drying machine\n\n-Used unsustainable detergent\n-Didn't clean out lint filter before using drying machine\n-Used hot wash cycle\n\n
        Good attempt! We recommend cleaning out your lint filter before using the drying machine. This allows for more efficient heating and drying!".Replace($@"\n", System.Environment.NewLine),

        [6] = $@"+ Used clothesline\n+ Used shorter wash cycle\n\n- Used unsustainable detergent\n- Used hot wash cycle\n\n
        Good attempt! We recommend using a cold wash and a shorter cycle to reduce energy consumption!".Replace($@"\n", System.Environment.NewLine),

        [7] = $@"+ Cleaned lint filter before using drying machine\n+ Used cold wash\n\n~ Used drying machine\n\n- Used a long wash\n- Used unsustainable detergent\n- Used long wash cycle\n\n
        Nice attempt! To increase your sustainability, we recommend limiting the use of the drying machine and opting for a shorter wash".Replace($@"\n", System.Environment.NewLine),

        [8] = $@"+ Used cold wash\n\n~ Used drying machine\n\n-Used unsustainable detergent\n- Didn't clean out lint filter before using drying machine\n- Used long wash\n\n
        Good attempt! We recommend cleaning out your lint filter before using the drying machine. This allows for more efficient heating and drying!".Replace($@"\n", System.Environment.NewLine),

        [9] = $@"+ Used clothesline\n+ Used cold wash cycle\n\n- Used unsustainable detergent\n- Used long wash\n\n
        Good attempt! We recommend using a shorter wash cycle to reduce energy consumption!".Replace($@"\n", System.Environment.NewLine),

        [10] = $@"+ Cleaned lint filter before using drying machine\n+ Used shorter wash cycle\n+ Used cold wash\n\n- Used unsustainable detergent\n- Used drying machine to dry clothes\n\n
        Nice attempt! To increase your sustainability, we recommend using a cold wash cycle to reduce your electricity usage".Replace($@"\n", System.Environment.NewLine),

        [11] = $@"+ Used shorter wash cycle\n+ Used cold wash\n\n~ Used drying machine\n\n- Used unsustainable detergent\n\n
        Nice attempt! To increase your sustainability, we recommend using a cold wash cycle to reduce your electricity usage".Replace($@"\n", System.Environment.NewLine),

        [12] = $@"+ Used clothesline\n+ Used shorter wash cycle\n+ Used cold wash cycle\n\n- Used unsustainable detergent\n\n
        Good attempt! We recommend using a more sustainable detergent to reduce environmental impact!".Replace($@"\n", System.Environment.NewLine),

        [13] = $@"+ Cleaned lint filter before using drying machine\n\n~ Used drying machine\n~ Used average detergent\n\n- Used hot wash cycle\n- Used long wash cycle\n\n
        Nice attempt! To increase your sustainability, we recommend limiting the use of the drying machine and opting for a shorter wash".Replace($@"\n", System.Environment.NewLine),

        [14] = $@"~ Used drying machine\n\n- Used average detergent\n- Didn't clean out lint filter before using drying machine\n- Used hot wash cycle\n- Used long wash\n\n
        Good attempt! We recommend cleaning out your lint filter before using the drying machine. This allows for more efficient heating and drying!".Replace($@"\n", System.Environment.NewLine),

        [15] = $@"+ Used clothesline\n\n~ Used average detergent\n\n- Used hot wash cycle\n- Used long wash\n\n
        Good attempt! We recommend using a cold wash and a shorter cycle to reduce energy consumption!".Replace($@"\n", System.Environment.NewLine),

        [16] = $@"+ Used shorter wash cycle\n\n- Used average detergent\n- Used hot wash cycle\n- Used drying machine to dry clothes\n\n
        Nice attempt! To increase your sustainability, we recommend using a cold wash cycle to reduce your electricity usage".Replace($@"\n", System.Environment.NewLine),

        [17] = $@"+ Used shorter wash cycle\n\n~ Used drying machine\n\n-Used average detergent\n-Used hot wash cycle\n\n
        Nice attempt! To increase your sustainability, we recommend using a cold wash cycle to reduce your electricity usage".Replace($@"\n", System.Environment.NewLine),

        [18] = $@"+ Used clothesline\n+ Used shorter wash cycle\n\n~ Used average detergent\n\n- Used hot wash cycle\n\n
        Good attempt! We recommend using a cold wash to reduce energy consumption!".Replace($@"\n", System.Environment.NewLine),

        [19] = $@"+ Used shorter wash cycle\n\n- Used average detergent\n- Used hot wash cycle\n- Used drying machine to dry clothes\n\n
        Nice attempt! To increase your sustainability, we recommend using a cold wash cycle to reduce your electricity usage".Replace($@"\n", System.Environment.NewLine),

        [20] = $@"+ Used shorter wash cycle\n\n- Used average detergent\n- Used hot wash cycle\n- Used drying machine to dry clothes\n\n
        Nice attempt! To increase your sustainability, we recommend using a cold wash cycle to reduce your electricity usage".Replace($@"\n", System.Environment.NewLine),

        [21] = $@"+ Used clothesline\n+ Used cold wash cycle\n\n~ Used average detergent\n\n-Used long wash\n\n
        Good attempt! We recommend using a shorter cycle to reduce energy consumption!".Replace($@"\n", System.Environment.NewLine),
        
        [22] = $@"+ Used shorter wash cycle\n\n- Used average detergent\n- Used hot wash cycle\n- Used drying machine to dry clothes\n\n
        Nice attempt! To increase your sustainability, we recommend using a cold wash cycle to reduce your electricity usage".Replace($@"\n", System.Environment.NewLine),

        [23] = $@"+ Used shorter wash cycle\n\n- Used average detergent\n- Used hot wash cycle\n- Used drying machine to dry clothes\n\n
        Nice attempt! To increase your sustainability, we recommend using a cold wash cycle to reduce your electricity usage".Replace($@"\n", System.Environment.NewLine),

        [24] = $@"+ Used clothesline\n+ Used shorter cycle\n\n~ Used average detergent\n\n- Used hot wash cycle\n\n
        Good attempt! We recommend using a cold wash and a shorter cycle to reduce energy consumption!".Replace($@"\n", System.Environment.NewLine),

        [25] = $@"+ Used sustainable detergent\n+ Cleaned lint filter before using drying machine\n\n~ Used drying machine\n\n- Used hot wash cycle\n- Used long wash cycle\n\n
        Nice attempt! To increase your sustainability, we recommend limiting the use of the drying machine and opting for a shorter wash!".Replace($@"\n", System.Environment.NewLine),

        [26] = $@"+ Used sustainable detergent\nn~ Used drying machine\nn- Didn't clean out lint filter before using drying machine\n- Used hot wash cycle\n- Used long wash\n\n
        Good attempt! We recommend cleaning out your lint filter before using the drying machine. This allows for more efficient heating and drying!".Replace($@"\n", System.Environment.NewLine),

        [27] = $@"+ Used clothesline\nn+ Used sustainable detergent\n\n- Used hot wash cycle\n- Used long wash\n\n
        Good attempt! We recommend using a shorter cycle to reduce energy consumption!".Replace($@"\n", System.Environment.NewLine),

        [28] = $@"+ Used sustainable detergent\n+ Used shorter wash cycle\n\n- Used hot wash cycle\n- Used drying machine to dry clothes\n\n
        Nice attempt! To increase your sustainability, we recommend using a cold wash cycle to reduce your electricity usage".Replace($@"\n", System.Environment.NewLine),

        [29] = $@"+ Used sustainable detergent\n+ Used drying machine\n+ Used shorter wash cycle\n\n- Used hot wash cycle\n\n
        Nice attempt! To increase your sustainability, we recommend using a cold wash cycle to reduce your electricity usage".Replace($@"\n", System.Environment.NewLine),

        [30] = $@"+ Used clothesline\n+ Used shorter wash cycle\n+ Used sustainable detergent\n\n- Used hot wash cycle\n\n
        Good attempt! We recommend using a cold wash to reduce energy consumption!".Replace($@"\n", System.Environment.NewLine),

        [31] = $@"+ Used sustainable detergent\n+ Cleaned lint filter before using drying machine\n+ Used cold wash\n\n~ Used drying machine\n\n- Used a long wash\n- Used long wash cycle\n\n
        Nice attempt! To increase your sustainability, we recommend limiting the use of the drying machine and opting for a shorter wash!".Replace($@"\n", System.Environment.NewLine),

        [32] = $@"+ Used sustainable detergentn\+ Used cold wash\n\n~ Used drying machine\n\n- Didn't clean out lint filter before using drying machine\n- Used long wash\n\n
        Good attempt! We recommend cleaning out your lint filter before using the drying machine. This allows for more efficient heating and drying!".Replace($@"\n", System.Environment.NewLine),

        [33] = $@"+ Used clothesline\n+ Used cold wash cycle\n+ Used sustainable detergent\n\n- Used long wash\n\n
        Good attempt! We recommend using a shorter wash to reduce energy consumption!".Replace($@"\n", System.Environment.NewLine),

        [34] = $@"+ Used sustainable detergent\n+ Used shorter wash cycle\n+ Used cold wash\n\n- Used drying machine to dry clothes\n\n
        Nice attempt! To increase your sustainability, we recommend using a cold wash cycle to reduce your electricity usage".Replace($@"\n", System.Environment.NewLine),

        [35] = $@"+ Used sustainable detergent\n+ Used clothes line to dry clothes\n+ Used shorter wash cycle\n+ Used cold wash\n\n- Didn't clean lint filter\n\n
        Nice attempt! To increase your sustainability, we recommend using a cold wash cycle to reduce your electricity usage".Replace($@"\n", System.Environment.NewLine),

        [36] = $@"+ Used clothesline\n+ Used shorter wash cycle\n+ Used cold wash cycle\n+ Used sustainable detergent\n\n
        Congratulations, it looks like you're well versed in these sustainability practices".Replace($@"\n", System.Environment.NewLine),

    };
}
