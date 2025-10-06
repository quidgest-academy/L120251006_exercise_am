/* eslint-disable @typescript-eslint/no-unused-vars */
import { computed, reactive, watch } from 'vue'
import _merge from 'lodash-es/merge'

import FormViewModelBase from '@/mixins/formViewModelBase.js'
import genericFunctions from '@quidgest/clientapp/utils/genericFunctions'
import modelFieldType from '@quidgest/clientapp/models/fields'

import hardcodedTexts from '@/hardcodedTexts.js'
import netAPI from '@quidgest/clientapp/network'
import qApi from '@/api/genio/quidgestFunctions.js'
import qFunctions from '@/api/genio/projectFunctions.js'
import qProjArrays from '@/api/genio/projectArrays.js'
/* eslint-enable @typescript-eslint/no-unused-vars */

/**
 * Represents a ViewModel class.
 * @extends FormViewModelBase
 */
export default class ViewModel extends FormViewModelBase
{
	/**
	 * Creates a new instance of the ViewModel.
	 * @param {object} vueContext - The Vue context
	 * @param {object} options - The options for the ViewModel
	 * @param {object} values - A ViewModel instance to copy values from
	 */
	// eslint-disable-next-line @typescript-eslint/no-unused-vars
	constructor(vueContext, options, values)
	{
		super(vueContext, options)
		// eslint-disable-next-line @typescript-eslint/no-unused-vars
		const vm = this.vueContext

		// The view model metadata
		_merge(this.modelInfo, {
			name: 'FR_001',
			area: 'T_001',
			actions: {
				recalculateFormulas: 'RecalculateFormulas_Fr_001',
				updateFilesTickets: 'UpdateFilesTicketsFr_001',
				setFile: 'SetFileFr_001'
			}
		})

		/** The primary key. */
		this.ValCodt_001 = reactive(new modelFieldType.PrimaryKey({
			id: 'ValCodt_001',
			originId: 'ValCodt_001',
			area: 'T_001',
			field: 'CODT_001',
			description: '',
		}).cloneFrom(values?.ValCodt_001))
		this.stopWatchers.push(watch(() => this.ValCodt_001.value, (newValue, oldValue) => this.onUpdate('t_001.codt_001', this.ValCodt_001, newValue, oldValue)))

		/** The remaining form fields. */
		this.ValPhoto = reactive(new modelFieldType.Image({
			id: 'ValPhoto',
			originId: 'ValPhoto',
			area: 'T_001',
			field: 'F_004',
			description: computed(() => this.Resources.PROFILE_PHOTO12166),
		}).cloneFrom(values?.ValPhoto))
		this.stopWatchers.push(watch(() => this.ValPhoto.value, (newValue, oldValue) => this.onUpdate('t_001.photo', this.ValPhoto, newValue, oldValue)))

		this.ValName = reactive(new modelFieldType.String({
			id: 'ValName',
			originId: 'ValName',
			area: 'T_001',
			field: 'F_001',
			maxLength: 50,
			description: computed(() => this.Resources.NAME31974),
		}).cloneFrom(values?.ValName))
		this.stopWatchers.push(watch(() => this.ValName.value, (newValue, oldValue) => this.onUpdate('t_001.name', this.ValName, newValue, oldValue)))

		this.ValEmail = reactive(new modelFieldType.String({
			id: 'ValEmail',
			originId: 'ValEmail',
			area: 'T_001',
			field: 'F_002',
			maxLength: 50,
			maskType: 'EM',
			description: computed(() => this.Resources.EMAIL25170),
		}).cloneFrom(values?.ValEmail))
		this.stopWatchers.push(watch(() => this.ValEmail.value, (newValue, oldValue) => this.onUpdate('t_001.email', this.ValEmail, newValue, oldValue)))

		this.ValDobirth = reactive(new modelFieldType.Date({
			id: 'ValDobirth',
			originId: 'ValDobirth',
			area: 'T_001',
			field: 'F_003',
			description: computed(() => this.Resources.DATE_OF_BIRTH36542),
		}).cloneFrom(values?.ValDobirth))
		this.stopWatchers.push(watch(() => this.ValDobirth.value, (newValue, oldValue) => this.onUpdate('t_001.dobirth', this.ValDobirth, newValue, oldValue)))
	}

	/**
	 * Creates a clone of the current QFormFr001ViewModel instance.
	 * @returns {QFormFr001ViewModel} A new instance of QFormFr001ViewModel
	 */
	clone()
	{
		return new ViewModel(this.vueContext, { callbacks: this.externalCallbacks }, this)
	}

	static QPrimaryKeyName = 'ValCodt_001'

	get QPrimaryKey() { return this.ValCodt_001.value }
	set QPrimaryKey(value) { this.ValCodt_001.updateValue(value) }
}
