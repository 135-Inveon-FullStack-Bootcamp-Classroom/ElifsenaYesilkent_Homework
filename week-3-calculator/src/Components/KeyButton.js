import { useContext } from "react";
import { CalcContext } from "../calcContext";

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
    const {valueText,lastValue,setLastValue,setValueText,setOperation,setOperationText,lastOperation,operation,setLastOperation}=useContext(CalcContext);
    

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
                    return setOperationText(valueText+label),setLastOperation(true),setOperation("+"),setValueText(Number(lastValue)+Number(valueText)),setLastValue(Number(valueText));
                case '-':
                  return  setOperationText(valueText+label),setLastOperation(true),setOperation("-"),setValueText(Number(lastValue)-Number(valueText)),setLastValue(Number(valueText));
                case 'x':
                  return  setOperationText(valueText+label),setLastOperation(true),setOperation("x"),setValueText(Number(lastValue)*Number(valueText)),setLastValue(Number(valueText));
                case '/':
                  return setOperationText(valueText+label),setLastOperation(true),setOperation("/"),setValueText(Number(lastValue)/Number(valueText)),setLastValue(Number(valueText));
                case '=':
                  console.log(operation)
                  if(operation==="+")
                    return   setValueText(Number(valueText)+lastValue),setOperationText(lastValue+operation+valueText+"=");
                  else if(operation==="-")
                    return  setValueText(Number(valueText)-lastValue),setOperationText(lastValue+operation+valueText+"=");
                  else if(operation==="x")
                    return  setValueText(Number(valueText)*lastValue),setOperationText(lastValue+operation+valueText+"=");
                  else if(operation==="/")
                    return  setValueText(Number(valueText)/lastValue),setOperationText(lastValue+operation+valueText+"=");
                  else
                  return   setValueText(Number(valueText));
                case '<-':
                  return   setValueText( valueText.slice(0,-1)); 
                case 'C':
                  return   setValueText("0"),setOperationText(""),setLastOperation(false),setLastValue(0); 
                case 'x^2':
                  return   setValueText(Math.pow(valueText, 2)),
                  setOperationText("sqr("+valueText+")"),setLastOperation(true),setLastValue(0);  
                case '1/x':
                  return  setValueText(1/Number(valueText)),
                  setOperationText("1/("+valueText+")"),setLastOperation(true),setLastValue(1/Number(valueText));
                case '√x':
                  return  setValueText(Math.sqrt(Number(valueText))),
                  setOperationText("√("+valueText+")"),setLastOperation(true),setLastValue(Math.sqrt(Number(valueText)));
                case ',':
                    if((valueText.search(".")===-1))
                        return setValueText(valueText+"."),setLastOperation(false),setLastValue(0),console.log((valueText.search(","))+" ve "+valueText); 
                case '+/-': 
                    if(valueText===0)
                        return
                    else if(Math.abs(valueText)===valueText)
                        return setValueText("-"+valueText),setLastOperation(false),setLastValue(0);
                    else 
                        return      
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