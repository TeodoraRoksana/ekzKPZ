import logo from './logo.svg';
import './App.css';

import { BrowserRouter, Routes, Route } from "react-router-dom";
import Layout from './components/Layout';
import InsertPage from './components/InsertPage';
import Home from './components/Home';
import History from './components/History';
import DeletePage from './components/DeletePage';
import UpdatePage from './components/UpdatePage';

function App() {
  return (
    <BrowserRouter>
    <Routes>
      <Route path="/" element={<Layout />}>
        <Route index element={<Home />} />
        <Route path="insert" element={<InsertPage />} />
        <Route path="history" element={<History />} />
        <Route path="delete" element={<DeletePage />} />
        <Route path="update" element={<UpdatePage />} />
      </Route>
    </Routes>
  </BrowserRouter>
  );
}

export default App;
