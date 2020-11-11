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
        
        // Clothesline one here
        
        [4] = $@"+ Used shorter wash cycle\n\n- Used unsustainable detergent\n- Used hot wash cycle\n- Used drying machine to dry clothes\n\n
        Nice attempt! To increase your sustainability, we recommend using a cold wash cycle to reduce your electricity usage".Replace($@"\n", System.Environment.NewLine),

        [5] = $@"+ Used shorter wash cycle\n\n~ Used drying machine\n\n-Used unsustainable detergent\n-Didn't clean out lint filter before using drying machine\n-Used hot wash cycle
        Good attempt! We recommend cleaning out your lint filter before using the drying machine. This allows for more efficient heating and drying!".Replace($@"\n", System.Environment.NewLine),

        // Clothesline one here

        [7] = $@"+ Cleaned lint filter before using drying machine\n+ Used cold wash\n\n~ Used drying machine\n\n- Used a long wash\n- Used unsustainable detergent\n- Used long wash cycle\n\n
        Nice attempt! To increase your sustainability, we recommend limiting the use of the drying machine and opting for a shorter wash".Replace($@"\n", System.Environment.NewLine),

        [8] = $@"+ Used cold wash\n\n~ Used drying machine\n\n-Used unsustainable detergent\n- Didn't clean out lint filter before using drying machine\n- Used long wash\n\n
        Good attempt! We recommend cleaning out your lint filter before using the drying machine. This allows for more efficient heating and drying!".Replace($@"\n", System.Environment.NewLine),

        // Clothesline one here

        [10] = $@"+ Cleaned lint filter before using drying machine\n+ Used shorter wash cycle\n+ Used cold wash\n\n- Used unsustainable detergent\n- Used drying machine to dry clothes\n\n
        Nice attempt! To increase your sustainability, we recommend using a cold wash cycle to reduce your electricity usage".Replace($@"\n", System.Environment.NewLine),

        [11] = $@"+ Used shorter wash cycle\n+ Used cold wash\n\n~ Used drying machine\n\n- Used unsustainable detergent\n\n
        Nice attempt! To increase your sustainability, we recommend using a cold wash cycle to reduce your electricity usage".Replace($@"\n", System.Environment.NewLine),

        // Clothesline one here

        [13] = $@"+ Cleaned lint filter before using drying machine\n\n~ Used drying machine\n~ Used average detergent\n\n- Used hot wash cycle\n- Used long wash cycle\n\n
        Nice attempt! To increase your sustainability, we recommend limiting the use of the drying machine and opting for a shorter wash".Replace($@"\n", System.Environment.NewLine),

        [14] = $@"~ Used drying machine\n\n- Used average detergent\n- Didn't clean out lint filter before using drying machine\n- Used hot wash cycle\n- Used long wash\n\n
        Good attempt! We recommend cleaning out your lint filter before using the drying machine. This allows for more efficient heating and drying!".Replace($@"\n", System.Environment.NewLine),

        // Clothesline goes here

        [16] = $@"+ Used shorter wash cycle\n\n- Used average detergent\n- Used hot wash cycle\n- Used drying machine to dry clothes\n\n
        Nice attempt! To increase your sustainability, we recommend using a cold wash cycle to reduce your electricity usage".Replace($@"\n", System.Environment.NewLine),

        [17] = $@"+ Used shorter wash cycle\n\n~ Used drying machine\n\n-Used average detergent\n-Used hot wash cycle\n\n
        Nice attempt! To increase your sustainability, we recommend using a cold wash cycle to reduce your electricity usage".Replace($@"\n", System.Environment.NewLine),

        // Clothesline goes here

        [19] = $@"+ Used shorter wash cycle\n\n- Used average detergent\n- Used hot wash cycle\n- Used drying machine to dry clothes\n\n
        Nice attempt! To increase your sustainability, we recommend using a cold wash cycle to reduce your electricity usage".Replace($@"\n", System.Environment.NewLine),

        [20] = $@"+ Used shorter wash cycle\n\n- Used average detergent\n- Used hot wash cycle\n- Used drying machine to dry clothes\n\n
        Nice attempt! To increase your sustainability, we recommend using a cold wash cycle to reduce your electricity usage".Replace($@"\n", System.Environment.NewLine),

        // Clothesline goes here
        
        [22] = $@"+ Used shorter wash cycle\n\n- Used average detergent\n- Used hot wash cycle\n- Used drying machine to dry clothes\n\n
        Nice attempt! To increase your sustainability, we recommend using a cold wash cycle to reduce your electricity usage".Replace($@"\n", System.Environment.NewLine),

        [23] = $@"+ Used shorter wash cycle\n\n- Used average detergent\n- Used hot wash cycle\n- Used drying machine to dry clothes\n\n
        Nice attempt! To increase your sustainability, we recommend using a cold wash cycle to reduce your electricity usage".Replace($@"\n", System.Environment.NewLine),

        // Clothesline goes here

    };
}
