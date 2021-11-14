import Header from "../Header";


const Layout=({children})=>{
    return(
        <div className="App">
            <Header/>
            <div style={{padding:"50px"}}>{children}</div>
        </div>
    );
};

export default Layout;