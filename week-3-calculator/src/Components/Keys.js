import KeyButton from "./KeyButton";

const styles={
    container:{
       // width:"100%",
        height:"60%",
        display:"flex",
        flexWrap: "wrap", 
        justifyContent:"space-around",
        //backgroundColor:"blue",
    },
    equals:{
        backgroundColor:"red",
    },

};

//const onClick = () => console.log('hi');

const Keys=()=>{
    return(
        <div style={styles.container}>
         <KeyButton label="%"  />
         <KeyButton label="CE"/>
         <KeyButton label="C"/>
         <KeyButton label="<-"/>

         <KeyButton label="1/x" />
         <KeyButton label="x^2"/>
         <KeyButton label="√x"/>
         <KeyButton label="/"/>

         <KeyButton label="7" lightKey isNumber />
         <KeyButton label="8"lightKey isNumber/>
         <KeyButton label="9" lightKey isNumber/>
         <KeyButton label="x"/>

         <KeyButton label="4" lightKey isNumber/>
         <KeyButton label="5" lightKey isNumber/>
         <KeyButton label="6" lightKey isNumber/>
         <KeyButton label="-"/>

         <KeyButton label="1"  lightKey isNumber/>
         <KeyButton label="2" lightKey isNumber/>
         <KeyButton label="3" lightKey isNumber/>
         <KeyButton label="+"/>

         <KeyButton label="+/-" lightKey/>
         <KeyButton label="0" lightKey isNumber/>
         <KeyButton label="," lightKey/>
         <KeyButton label="=" isBlue/>
        </div>
    );
};

export default Keys;