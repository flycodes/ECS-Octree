﻿using Unity.Mathematics ;
using Unity.Entities ;


namespace ECS.Blocks
{   
    
    public struct AddBlockData : IComponentData 
    {    
        public float3 f3_position ; 
        
        public float3 f3_scale ;

        public float4 f4_color ;
    }
    
    public struct RemoveBlockTag : IComponentData {}    

}
