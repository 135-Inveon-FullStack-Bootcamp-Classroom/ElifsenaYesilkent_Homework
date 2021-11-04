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
    return(
    <div style={Styles.screen}>
        <div style={Styles.operation}>
            25+45
        </div>
        <div style={Styles.value}>
            35
        </div>
    </div>
    );
};

export default Screen;