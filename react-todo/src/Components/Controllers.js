const Controllers=({inputValue,setInputValue,buttonClick})=>(

    <div style={{marginLeft: "250px", height:"80px", marginRight: "250px", marginTop:"20px", backgroundColor :"#AEB6BF", 
    display: "flex",  justifyContent: "space-evenly"}}>
        <input input={inputValue}  onChange={(e)=> setInputValue(e.target.value)} type="text"  style={{ margin:"20px",   width: "600px",  height: "30px", fontSize: "25px"}}></input>
         <input type="button" onClick={buttonClick}  value="Kaydet"
        style={{ width: "105px", height: "33px" ,marginTop:"20px"}}></input>
    </div>
);

export default Controllers;