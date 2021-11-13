const styles={
    appContainer:{
        display:"flex",
        justifyContent:"center",
        alignItems:"center",
        width:"100vw",
        height:"100vh",
        backgroundColor:"#eeedf1"
    },
    calculatorContainer:{
        backgroundColor:"#1a1f32",
        width:"20vw",
        height:"30vw",
    },
};

const AppContainer=({children})=>{
    return(
        <div style={styles.appContainer}>
            <div style={styles.calculatorContainer}>{children}</div>
        </div>
    );
};

export default AppContainer;

//#2c3145 ust tuşlar(sayılar hariç kısım) arka rengi
//#eeedf1 tuş rengi(kendi)
//#353a4e sayıların arka rengi
//#4cc2ff eşittir arka renk
//#3796c2 eşittir rengi
//#1a1f32 ekran rengi(screen ust taraf)
//