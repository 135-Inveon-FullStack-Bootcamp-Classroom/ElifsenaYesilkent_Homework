import React, {createContext,useState} from "react";

export const CalcContext=createContext();

export const CalcProvider=({children})=>{
    const [valueText,setValueText]=useState("0");//işlem sonundaki değer
    const [lastValue,setLastValue]=useState(0);//işlem değeri girildikten sonra önceki sayıyı tutsun
    const [operationText,setOperationText]=useState("");//işlemin yapıldığı üst taraf 
    const [operation,setOperation]=useState();//son girilen değerin işlem olması ve tutulması
    const [lastOperation,setLastOperation]=useState(false);//son girilen değer işlem mi

    console.log({children})
    return(
        <CalcContext.Provider value={{valueText,setValueText,operationText,
        setOperationText,operation,setOperation,lastOperation,setLastOperation,lastValue,setLastValue}}>
            {children}
        </CalcContext.Provider>
    );
};