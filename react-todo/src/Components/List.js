import carpiEmoji from '../images/carpiEmoji.png';
import tikEmoji from '../images/tikEmoji.png';

//maddenin tamamlandı kısmı 
const check = (e) => {
    if(e.target.src===carpiEmoji)
        e.target.src=tikEmoji;
    else
        e.target.src=carpiEmoji;
}



const List = ({todos,allDeleteClick,deleteButton}) => (
    
    <div style={{marginLeft: "250px", marginRight: "250px", marginTop:"10px", backgroundColor :"#D5DBDB", 
    display: "flex", flexDirection: "column", }}>
        <h2 style={{marginLeft:"60px"}}>Yapılacaklar</h2>
    <ul style={{marginLeft:"60px" }}>{todos.map((item)=>( /*listenin gösterildiği yer*/
         <li style={{fontSize:"25px"}}>
            {/* listenin içindekiler */}
            {item.text} 
            {/*liste tamamlandı butonu*/ }
            <input  style={{marginLeft:"10px", width: "18px",  height: "18px"}} type="image"  
            src={carpiEmoji} onClick={check}
            ></input>
            <span style={{position: "absolute" ,right: "350px" , fontSize:"18px",backgroundColor:"#ECF0F1"}}>
            {item.date.getDate() + "-"+ parseInt(item.date.getMonth()+1) +"-"+item.date.getFullYear()}
            </span>
            {/* listedeki maddeyi sil*/ }
            <button onClick={deleteButton} style={{position: "absolute" ,right: "300px"}}>Sil</button>
        </li>))}
    </ul>
    <button style={{width:"100px", marginLeft:"60px", marginBottom:"20px"}} 
    onClick={allDeleteClick}>Hepsini Sil</button>
    </div>
); 


export default List;