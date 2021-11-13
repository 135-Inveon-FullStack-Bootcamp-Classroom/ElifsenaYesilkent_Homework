const styles={
    header:{
        color:"#eeedf1",
        paddingLeft:"10px",
        paddingRight:"3px",
    },
    text:{
        fontSize:"13px",
    },
};

const TopHeader=()=>
{
    return(
        <div style={styles.header}>
            <span style={styles.text}>Calculator </span>
        </div>
        
    );
};

export default TopHeader;
