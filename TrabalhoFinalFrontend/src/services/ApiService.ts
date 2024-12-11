import axios from "axios";

const ApiService = axios.create({
  baseURL: "http://localhost:5072", // URL HTTP
});

export default ApiService;
