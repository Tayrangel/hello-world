import React from 'react';
import ReactDOM from 'react-dom';
import "./style.css"

const App = () => {

  return (
    <div className="App"> 
      Hello World!
    </div>
  )
}

ReactDOM.render(
  <React.StrictMode>
    <App />
  </React.StrictMode>,
  document.getElementById('root')
);

