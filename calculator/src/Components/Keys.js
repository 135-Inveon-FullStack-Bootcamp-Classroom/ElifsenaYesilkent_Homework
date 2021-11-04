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

         <KeyButton label="1/x"/>
         <KeyButton label="x^2"/>
         <KeyButton label="√x"/>
         <KeyButton label="/"/>

         <KeyButton label="7" lightKey />
         <KeyButton label="8"lightKey/>
         <KeyButton label="9" lightKey/>
         <KeyButton label="x"/>

         <KeyButton label="4" lightKey/>
         <KeyButton label="5" lightKey/>
         <KeyButton label="6" lightKey/>
         <KeyButton label="-"/>

         <KeyButton label="1"  lightKey />
         <KeyButton label="2" lightKey/>
         <KeyButton label="3" lightKey/>
         <KeyButton label="+"/>

         <KeyButton label="+/-" lightKey/>
         <KeyButton label="0" lightKey/>
         <KeyButton label="," lightKey/>
         <KeyButton label="=" isBlue/>
        </div>
    );
};

export default Keys;