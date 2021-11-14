import { useEffect, useState } from "react";
import Layout from "./Layout";
import MemeCard from "./MemeCard";


const CapsList=()=>{
    const [memes,setMemes]=useState();
    useEffect(()=>{
        fetch("https://api.imgflip.com/get_memes")
        .then((response)=> response.json())
        .then((result)=>setMemes(result.data.memes));
    });
    console.log(memes)
    return (
        <Layout>
            {memes.map((meme)=>
            
             <img src={meme.url} alt="Italian Trulli"></img>
        
            )};
         
            
            
        </Layout>
    );
};

export default CapsList;