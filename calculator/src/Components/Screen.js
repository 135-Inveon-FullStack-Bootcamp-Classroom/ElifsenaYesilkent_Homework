import { CalcContext } from "../calcContext";
import { useContext } from "react";

const Styles={
    screen:{
        //backgroundColor:"red",
        height:"35%",
        display: "flex",
        flexDirection: "column",
        justifyContent:"Center",
        color:"#eeedf1",
        
    },
    operation:{
        height:"35%",
        //backgroundColor:"grey",
        display: "flex",
        justifyContent:"flex-end",
        //justify-content: flex-start | flex-end | center | space-between | space-around
        fontSize :"20px",
        marginRight:"15px",
        marginTop:"10px"

    },
    value:{
        height:"65%",
        //backgroundColor:"blue",
        display: "flex",
        justifyContent:"flex-end",
        fontSize :"55px",
        marginRight:"15px",
    }
    
};

const Screen=()=>{
    const {valueText,operationText} =useContext(CalcContext);//CalcContext'den değerleri alıyoruz
    return(
    <div style={Styles.screen}>
        <div style={Styles.operation}>
            {operationText}
        </div>
        <div style={Styles.value}>
            {valueText}
        </div>
    </div>
    );
};

export default Screen;