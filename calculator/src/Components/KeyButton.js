const styles={
    keyContainer:{
        width:"23%",
        height:"15.6%",
        backgroundColor:"#2c3145",
        color:"#eeedf1",
        display:"flex",
        alignItems:"center",
        justifyContent:"center"
    }
};




const KeyButton=({label,isBlue,lightKey})=>{
    
    
    const isBluestyle=isBlue?{backgroundColor:"#1e81b0"}:{};
    const isLightKey=lightKey?{backgroundColor:"#353a4e"}:{};
    
    return(
        <div style={{...styles.keyContainer,...isBluestyle,...isLightKey}} onClick={()=> console.log(label)}>
            <span>{label}</span>
        </div>
    );
}

export default KeyButton;