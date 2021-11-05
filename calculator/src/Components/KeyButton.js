import { useContext } from "react";
import { CalcContext } from "../CalcContext";

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




const KeyButton=({label,isBlue,lightKey,isNumber})=>{
    const {valueText,lastValue,setLastValue,setValueText,setOperation,setOperationText,lastOperation,setLastOperation}=useContext(CalcContext);
    

    const isBluestyle=isBlue?{backgroundColor:"#1e81b0"}:{};
    const isLightKey=lightKey?{backgroundColor:"#353a4e"}:{};
    
    const NumberOnClick=()=>{
        
        if(isNumber)
        {
            if(valueText==="0")
            {
                setValueText(label);
            }
            else if(lastOperation)
            {
                setLastOperation(false);
                setValueText(label);
            }
            else
            {
                setValueText(valueText+label);
            }
        }
        else
        {
            switch(label) {
                case '+':
                    return setOperationText(valueText+label),setLastOperation(true),setValueText(Number(lastValue)+Number(valueText)),setLastValue(Number(valueText));
                case '-':
                  return  setOperationText(valueText+label),setLastOperation(true),setValueText(Number(lastValue)-Number(valueText)),setLastValue(Number(valueText));
                case 'x':
                  return  setOperationText(valueText+label),setLastOperation(true),setValueText(Number(lastValue)*Number(valueText)),setLastValue(Number(valueText));
                case '/':
                  return setOperationText(valueText+label),setLastOperation(true),setValueText(Number(lastValue)/Number(valueText)),setLastValue(Number(valueText));
                case '=':
                  return   setValueText(Number(valueText))
                default:
                  return console.log("başka değer");
            }
        }

    };
    return(
        <div style={{...styles.keyContainer,...isBluestyle,...isLightKey}} onClick={NumberOnClick}>
            <span>{label}</span>
        </div>
    );
};

export default KeyButton;