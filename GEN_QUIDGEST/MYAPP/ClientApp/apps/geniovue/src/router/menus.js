// eslint-disable-next-line @typescript-eslint/no-unused-vars
import { updateQueryParams } from './routeUtils.js'

export default function getMenusRoutes()
{
	return [
		{
			path: '/:culture/:system/RMS/menu/RMS_21',
			name: 'menu-RMS_21',
			component: () => import('@/views/menus/ModuleRMS/MenuRMS_21/QMenuRms21.vue'),
			meta: {
				routeType: 'menu',
				module: 'RMS',
				order: '21',
				baseArea: 'T_001',
				hasInitialPHE: false,
				humanKeyFields: ['ValEmail'],
			}
		},
		{
			path: '/:culture/:system/RMS/menu/RMS_311',
			name: 'menu-RMS_311',
			component: () => import('@/views/menus/ModuleRMS/MenuRMS_311/QMenuRms311.vue'),
			meta: {
				routeType: 'menu',
				module: 'RMS',
				order: '311',
				baseArea: 'T_004',
				hasInitialPHE: false,
				humanKeyFields: ['ValCity'],
			}
		},
		{
			path: '/:culture/:system/RMS/menu/RMS_11',
			name: 'menu-RMS_11',
			component: () => import('@/views/menus/ModuleRMS/MenuRMS_11/QMenuRms11.vue'),
			meta: {
				routeType: 'menu',
				module: 'RMS',
				order: '11',
				baseArea: 'T_002',
				hasInitialPHE: false,
				humanKeyFields: ['ValTitle'],
			}
		},
		{
			path: '/:culture/:system/RMS/menu/RMS_321',
			name: 'menu-RMS_321',
			component: () => import('@/views/menus/ModuleRMS/MenuRMS_321/QMenuRms321.vue'),
			meta: {
				routeType: 'menu',
				module: 'RMS',
				order: '321',
				baseArea: 'T_003',
				hasInitialPHE: false,
				humanKeyFields: ['ValCountry'],
			}
		},
	]
}
